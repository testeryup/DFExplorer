namespace DFExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.lbPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExportIV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImportIV = new System.Windows.Forms.Button();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportAES = new System.Windows.Forms.Button();
            this.btnImportAES = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnFolderLoad = new System.Windows.Forms.Button();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHide = new System.Windows.Forms.DataGridViewButtonColumn();
            this.unHide = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.FileName,
            this.PathFile,
            this.btnDelete,
            this.btnHide,
            this.unHide});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiles.Location = new System.Drawing.Point(0, 180);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.Size = new System.Drawing.Size(761, 313);
            this.dgvFiles.TabIndex = 8;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentClick);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPath.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.lbPath.Location = new System.Drawing.Point(77, 6);
            this.lbPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(0, 17);
            this.lbPath.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(212, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 118);
            this.panel1.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnExportIV);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnImportIV);
            this.groupBox3.Controls.Add(this.txtIV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 51);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AES IV";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(372, -42);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "Export AES key";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExportIV
            // 
            this.btnExportIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(76)))));
            this.btnExportIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportIV.FlatAppearance.BorderSize = 0;
            this.btnExportIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportIV.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportIV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportIV.Location = new System.Drawing.Point(382, 17);
            this.btnExportIV.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportIV.Name = "btnExportIV";
            this.btnExportIV.Size = new System.Drawing.Size(120, 25);
            this.btnExportIV.TabIndex = 18;
            this.btnExportIV.Text = "Export IV key";
            this.btnExportIV.UseVisualStyleBackColor = false;
            this.btnExportIV.Click += new System.EventHandler(this.btnExportAES_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(252, -42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Import AES key";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnImportIV
            // 
            this.btnImportIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.btnImportIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportIV.FlatAppearance.BorderSize = 0;
            this.btnImportIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportIV.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportIV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportIV.Location = new System.Drawing.Point(262, 17);
            this.btnImportIV.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportIV.Name = "btnImportIV";
            this.btnImportIV.Size = new System.Drawing.Size(116, 25);
            this.btnImportIV.TabIndex = 17;
            this.btnImportIV.Text = "Import IV key";
            this.btnImportIV.UseVisualStyleBackColor = false;
            this.btnImportIV.Click += new System.EventHandler(this.btnImportIV_Click);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(5, 19);
            this.txtIV.Margin = new System.Windows.Forms.Padding(2);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(243, 21);
            this.txtIV.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExportAES);
            this.groupBox2.Controls.Add(this.btnImportAES);
            this.groupBox2.Controls.Add(this.txtKey);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 51);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES Key";
            // 
            // btnExportAES
            // 
            this.btnExportAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(76)))));
            this.btnExportAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportAES.FlatAppearance.BorderSize = 0;
            this.btnExportAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAES.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportAES.Location = new System.Drawing.Point(382, 17);
            this.btnExportAES.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportAES.Name = "btnExportAES";
            this.btnExportAES.Size = new System.Drawing.Size(120, 25);
            this.btnExportAES.TabIndex = 18;
            this.btnExportAES.Text = "Export AES key";
            this.btnExportAES.UseVisualStyleBackColor = false;
            this.btnExportAES.Click += new System.EventHandler(this.btnExportAES_Click);
            // 
            // btnImportAES
            // 
            this.btnImportAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(87)))), ((int)(((byte)(105)))));
            this.btnImportAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportAES.FlatAppearance.BorderSize = 0;
            this.btnImportAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportAES.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportAES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportAES.Location = new System.Drawing.Point(262, 17);
            this.btnImportAES.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportAES.Name = "btnImportAES";
            this.btnImportAES.Size = new System.Drawing.Size(116, 25);
            this.btnImportAES.TabIndex = 17;
            this.btnImportAES.Text = "Import AES key";
            this.btnImportAES.UseVisualStyleBackColor = false;
            this.btnImportAES.Click += new System.EventHandler(this.btnImportAES_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(5, 19);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(243, 21);
            this.txtKey.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.btnFolderLoad);
            this.panel2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(23, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 128);
            this.panel2.TabIndex = 20;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(201)))), ((int)(((byte)(131)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Location = new System.Drawing.Point(5, 48);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 30);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate Keys";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(73)))));
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.Location = new System.Drawing.Point(100, 86);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 30);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(87)))), ((int)(((byte)(223)))));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.Location = new System.Drawing.Point(5, 86);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 30);
            this.btnEncrypt.TabIndex = 17;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnFolderLoad
            // 
            this.btnFolderLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(76)))));
            this.btnFolderLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolderLoad.FlatAppearance.BorderSize = 0;
            this.btnFolderLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderLoad.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFolderLoad.Location = new System.Drawing.Point(5, 10);
            this.btnFolderLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnFolderLoad.Name = "btnFolderLoad";
            this.btnFolderLoad.Size = new System.Drawing.Size(170, 30);
            this.btnFolderLoad.TabIndex = 16;
            this.btnFolderLoad.Text = "Load Folder";
            this.btnFolderLoad.UseVisualStyleBackColor = false;
            this.btnFolderLoad.Click += new System.EventHandler(this.btnFolderLoad_Click);
            // 
            // Selected
            // 
            this.Selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selected.HeaderText = "Select";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.ToolTipText = "Select your files to encrypt or decrypt";
            this.Selected.Width = 60;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FileName.ToolTipText = "File Name";
            this.FileName.Width = 150;
            // 
            // PathFile
            // 
            this.PathFile.HeaderText = "File Path";
            this.PathFile.MinimumWidth = 6;
            this.PathFile.Name = "PathFile";
            this.PathFile.ReadOnly = true;
            this.PathFile.ToolTipText = "Path of the file";
            this.PathFile.Width = 275;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 75;
            // 
            // btnHide
            // 
            this.btnHide.HeaderText = "";
            this.btnHide.Name = "btnHide";
            this.btnHide.ReadOnly = true;
            this.btnHide.Text = "Hide";
            this.btnHide.UseColumnTextForButtonValue = true;
            this.btnHide.Width = 75;
            // 
            // unHide
            // 
            this.unHide.HeaderText = "";
            this.unHide.Name = "unHide";
            this.unHide.ReadOnly = true;
            this.unHide.Text = "Unhide";
            this.unHide.ToolTipText = "Unhide the file";
            this.unHide.UseColumnTextForButtonValue = true;
            this.unHide.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DFExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExportIV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImportIV;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportAES;
        private System.Windows.Forms.Button btnImportAES;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnFolderLoad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathFile;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnHide;
        private System.Windows.Forms.DataGridViewButtonColumn unHide;
    }
}

