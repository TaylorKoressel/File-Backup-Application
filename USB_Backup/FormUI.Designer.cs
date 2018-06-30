namespace USB_Backup
{
    partial class FormUI
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
            this.tbTargetDir = new System.Windows.Forms.TextBox();
            this.tbfile = new System.Windows.Forms.TextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.fbdTargetDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGoPage_3 = new System.Windows.Forms.Button();
            this.gbPage_1 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFile = new System.Windows.Forms.Panel();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.gbFolder = new System.Windows.Forms.Panel();
            this.btnchooseFolder = new System.Windows.Forms.Button();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.gbStorageLocation = new System.Windows.Forms.GroupBox();
            this.btnToChoose = new System.Windows.Forms.Button();
            this.gbPage_3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbPage_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFile.SuspendLayout();
            this.gbFolder.SuspendLayout();
            this.gbStorageLocation.SuspendLayout();
            this.gbPage_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTargetDir
            // 
            this.tbTargetDir.Location = new System.Drawing.Point(46, 45);
            this.tbTargetDir.Name = "tbTargetDir";
            this.tbTargetDir.Size = new System.Drawing.Size(255, 26);
            this.tbTargetDir.TabIndex = 17;
            // 
            // tbfile
            // 
            this.tbfile.Location = new System.Drawing.Point(33, 24);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(255, 26);
            this.tbfile.TabIndex = 15;
            // 
            // lblDirections
            // 
            this.lblDirections.Location = new System.Drawing.Point(23, 22);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(511, 31);
            this.lblDirections.TabIndex = 13;
            this.lblDirections.Text = "Select a file or folder then select where you want the backup to be saved.\r\n";
            // 
            // btnGoPage_3
            // 
            this.btnGoPage_3.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnGoPage_3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoPage_3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoPage_3.Location = new System.Drawing.Point(353, 590);
            this.btnGoPage_3.Name = "btnGoPage_3";
            this.btnGoPage_3.Size = new System.Drawing.Size(173, 42);
            this.btnGoPage_3.TabIndex = 24;
            this.btnGoPage_3.Text = "&Backup";
            this.btnGoPage_3.UseVisualStyleBackColor = false;
            this.btnGoPage_3.Click += new System.EventHandler(this.btnGoPage_3_Click);
            // 
            // gbPage_1
            // 
            this.gbPage_1.BackColor = System.Drawing.SystemColors.Window;
            this.gbPage_1.Controls.Add(this.lblError);
            this.gbPage_1.Controls.Add(this.groupBox1);
            this.gbPage_1.Controls.Add(this.gbStorageLocation);
            this.gbPage_1.Controls.Add(this.btnGoPage_3);
            this.gbPage_1.Controls.Add(this.lblDirections);
            this.gbPage_1.Location = new System.Drawing.Point(27, 33);
            this.gbPage_1.Name = "gbPage_1";
            this.gbPage_1.Size = new System.Drawing.Size(559, 665);
            this.gbPage_1.TabIndex = 28;
            this.gbPage_1.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(66, 529);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(458, 18);
            this.lblError.TabIndex = 32;
            this.lblError.Text = "* ERROR: A file/folder and a save location must be selected ";
            this.lblError.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gbFile);
            this.groupBox1.Controls.Add(this.gbFolder);
            this.groupBox1.Controls.Add(this.rbFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbFolder);
            this.groupBox1.Location = new System.Drawing.Point(26, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 297);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Folder";
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.btnChooseFile);
            this.gbFile.Controls.Add(this.tbfile);
            this.gbFile.Location = new System.Drawing.Point(15, 49);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(457, 67);
            this.gbFile.TabIndex = 31;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(294, 15);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(135, 42);
            this.btnChooseFile.TabIndex = 32;
            this.btnChooseFile.Text = "Choose";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // gbFolder
            // 
            this.gbFolder.Controls.Add(this.btnchooseFolder);
            this.gbFolder.Controls.Add(this.tbFolder);
            this.gbFolder.Enabled = false;
            this.gbFolder.Location = new System.Drawing.Point(13, 166);
            this.gbFolder.Name = "gbFolder";
            this.gbFolder.Size = new System.Drawing.Size(457, 65);
            this.gbFolder.TabIndex = 31;
            // 
            // btnchooseFolder
            // 
            this.btnchooseFolder.Location = new System.Drawing.Point(296, 10);
            this.btnchooseFolder.Name = "btnchooseFolder";
            this.btnchooseFolder.Size = new System.Drawing.Size(135, 42);
            this.btnchooseFolder.TabIndex = 32;
            this.btnchooseFolder.Text = "Choose";
            this.btnchooseFolder.UseVisualStyleBackColor = true;
            this.btnchooseFolder.Click += new System.EventHandler(this.btnchooseFolder_Click_1);
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(33, 19);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(255, 26);
            this.tbFolder.TabIndex = 20;
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Checked = true;
            this.rbFile.Location = new System.Drawing.Point(13, 27);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(17, 16);
            this.rbFile.TabIndex = 24;
            this.rbFile.TabStop = true;
            this.rbFile.UseVisualStyleBackColor = true;
            this.rbFile.CheckedChanged += new System.EventHandler(this.rbFile_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "File";
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Location = new System.Drawing.Point(13, 144);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(17, 16);
            this.rbFolder.TabIndex = 25;
            this.rbFolder.TabStop = true;
            this.rbFolder.UseVisualStyleBackColor = true;
            this.rbFolder.CheckedChanged += new System.EventHandler(this.rbFolder_CheckedChanged);
            // 
            // gbStorageLocation
            // 
            this.gbStorageLocation.BackColor = System.Drawing.SystemColors.Window;
            this.gbStorageLocation.Controls.Add(this.btnToChoose);
            this.gbStorageLocation.Controls.Add(this.tbTargetDir);
            this.gbStorageLocation.Location = new System.Drawing.Point(26, 393);
            this.gbStorageLocation.Name = "gbStorageLocation";
            this.gbStorageLocation.Size = new System.Drawing.Size(500, 100);
            this.gbStorageLocation.TabIndex = 26;
            this.gbStorageLocation.TabStop = false;
            this.gbStorageLocation.Text = "Save Location";
            // 
            // btnToChoose
            // 
            this.btnToChoose.Location = new System.Drawing.Point(309, 36);
            this.btnToChoose.Name = "btnToChoose";
            this.btnToChoose.Size = new System.Drawing.Size(135, 42);
            this.btnToChoose.TabIndex = 32;
            this.btnToChoose.Text = "Choose";
            this.btnToChoose.UseVisualStyleBackColor = true;
            this.btnToChoose.Click += new System.EventHandler(this.btnToChoose_Click_1);
            // 
            // gbPage_3
            // 
            this.gbPage_3.BackColor = System.Drawing.SystemColors.Window;
            this.gbPage_3.Controls.Add(this.button3);
            this.gbPage_3.Controls.Add(this.btnExit);
            this.gbPage_3.Controls.Add(this.label4);
            this.gbPage_3.Location = new System.Drawing.Point(27, 33);
            this.gbPage_3.Name = "gbPage_3";
            this.gbPage_3.Size = new System.Drawing.Size(559, 665);
            this.gbPage_3.TabIndex = 30;
            this.gbPage_3.TabStop = false;
            this.gbPage_3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrchid;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(39, 585);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Create another backup";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(305, 585);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 47);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(138, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 58);
            this.label4.TabIndex = 0;
            this.label4.Text = "Success!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1153, 729);
            this.Controls.Add(this.gbPage_3);
            this.Controls.Add(this.gbPage_1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUI";
            this.Text = "Create a new backup";
            this.gbPage_1.ResumeLayout(false);
            this.gbPage_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFile.ResumeLayout(false);
            this.gbFile.PerformLayout();
            this.gbFolder.ResumeLayout(false);
            this.gbFolder.PerformLayout();
            this.gbStorageLocation.ResumeLayout(false);
            this.gbStorageLocation.PerformLayout();
            this.gbPage_3.ResumeLayout(false);
            this.gbPage_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox tbTargetDir;
        internal System.Windows.Forms.TextBox tbfile;
        internal System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.FolderBrowserDialog fbdTargetDir;
        private System.Windows.Forms.Button btnGoPage_3;
        private System.Windows.Forms.GroupBox gbPage_1;
        private System.Windows.Forms.GroupBox gbPage_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.GroupBox gbStorageLocation;
        private System.Windows.Forms.Panel gbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel gbFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnchooseFolder;
        private System.Windows.Forms.Button btnToChoose;
        private System.Windows.Forms.Label lblError;
    }
}

