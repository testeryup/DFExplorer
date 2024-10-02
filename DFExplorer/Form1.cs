using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DFExplorer;

namespace DFExplorer
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.DataGridView dgvFiles;
        private string filePath;
        //private string folderPath;
        private byte[] aesKey;
        private byte[] aesIV;
        public Form1()
        {

            InitializeComponent();
            //dgvFiles = new DataGridView
            //{
            //    Dock = DockStyle.Fill,
            //    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            //    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            //    MultiSelect = true
            //};
            //Controls.Add(dgvFiles);
        }
        

        private void btnFolderLoad_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path"})
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fbd.SelectedPath;
                    lbPath.Text = filePath; // Update folder path in the UI if needed
                    LoadFilesToTable(filePath);
                }
            }
        }
        private void LoadFilesToTable(string folderPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            FileInfo[] files = dirInfo.GetFiles(); // Get all files in the folder

            // Clear the DataGridView before loading new data
            dgvFiles.Rows.Clear();
            
            // Add rows to the DataGridView
            foreach (FileInfo file in files)
            {
                dgvFiles.Rows.Add(false, file.Name, file.FullName);
            }
        }
        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell cell = this.dgvFiles.CurrentCell as DataGridViewCheckBoxCell;

            if (cell != null && !cell.ReadOnly)
            {
                cell.Value = cell.Value == null || !((bool)cell.Value);
                this.dgvFiles.RefreshEdit();
                this.dgvFiles.NotifyCurrentCellDirty(true);
            }
        }

        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvFiles.RefreshEdit();
        }
        private List<string> GetSelectedFiles()
        {
            List<string> selectedFiles = new List<string>();

            foreach (DataGridViewRow row in dgvFiles.Rows)
            {
                // Check if the checkbox is checked (true) in the "Selected" column
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Selected"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value == true)
                {
                    string filePath = row.Cells["PathFile"].Value.ToString(); // Assuming "PathFile" is the column name
                    selectedFiles.Add(filePath);
                }
            }

            return selectedFiles;
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog() { Title = "Select your path" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    this.filePath = file.FileName;
                    lbPath.Text = filePath;
                    MessageBox.Show(filePath);
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            List<string> selectedFiles = GetSelectedFiles();
            if (selectedFiles.Count < 1)
            {
                MessageBox.Show("Please select at least one file to encrypt.");
                return;
            }
            if (String.IsNullOrEmpty(txtIV.Text) || String.IsNullOrEmpty(txtIV.Text))
            {
                MessageBox.Show("Please input a valid keys!");
                return;
            }
            string selectedFileNames = string.Join("\n", selectedFiles.Select(f => Path.GetFileName(f)));
            DialogResult result = MessageBox.Show($"Are you sure you want to encrypt the following files with AES?\n{selectedFileNames}",
                                         "Confirm Encryption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (string file in selectedFiles)
                {
                    byte[] fileContent = File.ReadAllBytes(file); // Read the file as bytes
                    byte[] encryptedContent = EncryptionHelper.EncryptAES(fileContent, aesKey, aesIV);
                    File.WriteAllBytes(file + ".df", encryptedContent); // Save as .df
                }
                MessageBox.Show("Selected files encrypted with AES successfully!");
                LoadFilesToTable(filePath); // Reload the files after encryption
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            List<string> selectedFiles = GetSelectedFiles();
            if (selectedFiles.Count < 1)
            {
                MessageBox.Show("Please select at least one file to decrypt.");
                return;
            }

            // Check if all selected files have the correct encrypted ".df" extension
            if (selectedFiles.Any(file => !file.EndsWith(".df")))
            {
                MessageBox.Show("Some selected files are not encrypted (missing .df extension). Please select only encrypted files.");
                return;
            }

            // Prepare a string that lists all the selected files
            string selectedFileNames = string.Join("\n", selectedFiles.Select(f => Path.GetFileName(f)));

            // Ask user to confirm decryption for all selected files
            DialogResult result = MessageBox.Show($"Are you sure you want to decrypt the following files with AES?\n{selectedFileNames}",
                                                  "Confirm Decryption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (string file in selectedFiles)
                {
                    if (!file.EndsWith(".df"))
                    {
                        MessageBox.Show($"File {file} is not encrypted (.df file expected).");
                        continue;
                    }

                    byte[] encryptedContent = File.ReadAllBytes(file); // Read the encrypted bytes
                    byte[] decryptedContent = EncryptionHelper.DecryptAES(encryptedContent, aesKey, aesIV);
                    File.WriteAllBytes(file.Replace(".df", ""), decryptedContent); // Save decrypted file
                }
                MessageBox.Show("Selected files decrypted with AES successfully!");
                LoadFilesToTable(filePath); // Reload the files after decryption
            }
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            (aesKey, aesIV) = EncryptionHelper.GenerateAESKeyAndIV();
            MessageBox.Show("AES Key and IV generated successfully!");
            // Display the key and IV in the form (you can use labels or text boxes)
            txtKey.Text = Convert.ToBase64String(aesKey);
            txtIV.Text = Convert.ToBase64String(aesIV);
        }

        private void btnImportAES_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Title = "Select AES Key File" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (filePath.EndsWith(".key"))
                    {
                        aesKey = EncryptionHelper.ImportKey(filePath);
                        txtKey.Text += Convert.ToBase64String(aesKey);
                    }
                    else
                    {
                        MessageBox.Show("AES key import failed!");
                    }
                }
            }
        }

        private void btnImportIV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Title = "Select IV Key File" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (filePath.EndsWith(".iv"))
                    {
                        aesIV = EncryptionHelper.ImportKey(filePath);
                        txtIV.Text += Convert.ToBase64String(aesIV);
                    }
                    else
                    {
                        MessageBox.Show("AES IV import failed!");
                    }
                }
            }
        }

        private void btnExportAES_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Title = "Save Key" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    EncryptionHelper.ExportKey(aesKey, filePath + ".key");
                    EncryptionHelper.ExportKey(aesIV, filePath + ".iv");
                    MessageBox.Show("Keys exported successfully!");
                }
            }
        }

        
    }
}
