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
            this.btnFolderLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PathFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExportIV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImportIV = new System.Windows.Forms.Button();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportAES = new System.Windows.Forms.Button();
            this.btnImportAES = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFolderLoad
            // 
            this.btnFolderLoad.BackColor = System.Drawing.Color.Gold;
            this.btnFolderLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFolderLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFolderLoad.Location = new System.Drawing.Point(19, 43);
            this.btnFolderLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFolderLoad.Name = "btnFolderLoad";
            this.btnFolderLoad.Size = new System.Drawing.Size(227, 37);
            this.btnFolderLoad.TabIndex = 1;
            this.btnFolderLoad.Text = "Load Folder";
            this.btnFolderLoad.UseVisualStyleBackColor = false;
            this.btnFolderLoad.Click += new System.EventHandler(this.btnFolderLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.BlueViolet;
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.Location = new System.Drawing.Point(19, 159);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 37);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.Location = new System.Drawing.Point(145, 159);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 37);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.FileName,
            this.PathFile});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFiles.Location = new System.Drawing.Point(0, 227);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.Size = new System.Drawing.Size(1019, 380);
            this.dgvFiles.TabIndex = 8;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "Select";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Width = 125;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 200;
            // 
            // PathFile
            // 
            this.PathFile.HeaderText = "File Path";
            this.PathFile.MinimumWidth = 6;
            this.PathFile.Name = "PathFile";
            this.PathFile.ReadOnly = true;
            this.PathFile.Width = 500;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(7, 23);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(323, 24);
            this.txtKey.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(264, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(735, 172);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnExportIV);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnImportIV);
            this.groupBox3.Controls.Add(this.txtIV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(20, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(692, 63);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AES IV";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(496, -52);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Export AES key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnExportAES_Click);
            // 
            // btnExportIV
            // 
            this.btnExportIV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExportIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportIV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportIV.Location = new System.Drawing.Point(509, 21);
            this.btnExportIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportIV.Name = "btnExportIV";
            this.btnExportIV.Size = new System.Drawing.Size(160, 31);
            this.btnExportIV.TabIndex = 18;
            this.btnExportIV.Text = "Export IV key";
            this.btnExportIV.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(336, -52);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Import AES key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnImportAES_Click);
            // 
            // btnImportIV
            // 
            this.btnImportIV.BackColor = System.Drawing.Color.Green;
            this.btnImportIV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportIV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportIV.Location = new System.Drawing.Point(349, 21);
            this.btnImportIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportIV.Name = "btnImportIV";
            this.btnImportIV.Size = new System.Drawing.Size(155, 31);
            this.btnImportIV.TabIndex = 17;
            this.btnImportIV.Text = "Import IV key";
            this.btnImportIV.UseVisualStyleBackColor = false;
            this.btnImportIV.Click += new System.EventHandler(this.btnImportIV_Click);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(7, 23);
            this.txtIV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(323, 24);
            this.txtIV.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExportAES);
            this.groupBox2.Controls.Add(this.btnImportAES);
            this.groupBox2.Controls.Add(this.txtKey);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(20, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(692, 63);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES Key";
            // 
            // btnExportAES
            // 
            this.btnExportAES.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExportAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportAES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportAES.Location = new System.Drawing.Point(509, 21);
            this.btnExportAES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportAES.Name = "btnExportAES";
            this.btnExportAES.Size = new System.Drawing.Size(160, 31);
            this.btnExportAES.TabIndex = 18;
            this.btnExportAES.Text = "Export AES key";
            this.btnExportAES.UseVisualStyleBackColor = false;
            this.btnExportAES.Click += new System.EventHandler(this.btnExportAES_Click);
            // 
            // btnImportAES
            // 
            this.btnImportAES.BackColor = System.Drawing.Color.Green;
            this.btnImportAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportAES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportAES.Location = new System.Drawing.Point(349, 21);
            this.btnImportAES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportAES.Name = "btnImportAES";
            this.btnImportAES.Size = new System.Drawing.Size(155, 31);
            this.btnImportAES.TabIndex = 17;
            this.btnImportAES.Text = "Import AES key";
            this.btnImportAES.UseVisualStyleBackColor = false;
            this.btnImportAES.Click += new System.EventHandler(this.btnImportAES_Click);
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.Color.Lime;
            this.lbPath.Location = new System.Drawing.Point(84, 11);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(0, 20);
            this.lbPath.TabIndex = 14;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Firebrick;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Location = new System.Drawing.Point(19, 99);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(227, 37);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Generate Keys";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1019, 607);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFolderLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DFExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFolderLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportAES;
        private System.Windows.Forms.Button btnImportAES;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExportIV;
        private System.Windows.Forms.Button btnImportIV;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

