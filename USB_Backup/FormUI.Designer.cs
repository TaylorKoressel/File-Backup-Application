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
            this.btnToChoose = new System.Windows.Forms.Button();
            this.btnFromChoose = new System.Windows.Forms.Button();
            this.tbTargetDir = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbStartDir = new System.Windows.Forms.TextBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.fbdStartDir = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdTargetDir = new System.Windows.Forms.FolderBrowserDialog();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.btnGoPage_3 = new System.Windows.Forms.Button();
            this.cbLocal = new System.Windows.Forms.CheckBox();
            this.gbCloud = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCloud = new System.Windows.Forms.CheckBox();
            this.gbPage_1 = new System.Windows.Forms.GroupBox();
            this.btnGoPage_2 = new System.Windows.Forms.Button();
            this.btnGoPage_1 = new System.Windows.Forms.Button();
            this.gbPage_2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPage_3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbLocal.SuspendLayout();
            this.gbCloud.SuspendLayout();
            this.gbPage_1.SuspendLayout();
            this.gbPage_2.SuspendLayout();
            this.gbPage_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToChoose
            // 
            this.btnToChoose.Location = new System.Drawing.Point(357, 35);
            this.btnToChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToChoose.Name = "btnToChoose";
            this.btnToChoose.Size = new System.Drawing.Size(118, 37);
            this.btnToChoose.TabIndex = 19;
            this.btnToChoose.Text = "Choose";
            this.btnToChoose.UseVisualStyleBackColor = true;
            this.btnToChoose.Click += new System.EventHandler(this.btnToChoose_Click);
            // 
            // btnFromChoose
            // 
            this.btnFromChoose.Location = new System.Drawing.Point(249, 105);
            this.btnFromChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFromChoose.Name = "btnFromChoose";
            this.btnFromChoose.Size = new System.Drawing.Size(118, 37);
            this.btnFromChoose.TabIndex = 18;
            this.btnFromChoose.Text = "Choose";
            this.btnFromChoose.UseVisualStyleBackColor = true;
            this.btnFromChoose.Click += new System.EventHandler(this.btnFromChoose_Click);
            // 
            // tbTargetDir
            // 
            this.tbTargetDir.Location = new System.Drawing.Point(127, 41);
            this.tbTargetDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTargetDir.Name = "tbTargetDir";
            this.tbTargetDir.Size = new System.Drawing.Size(224, 27);
            this.tbTargetDir.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 19);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Save Location:";
            // 
            // tbStartDir
            // 
            this.tbStartDir.Location = new System.Drawing.Point(19, 111);
            this.tbStartDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbStartDir.Name = "tbStartDir";
            this.tbStartDir.Size = new System.Drawing.Size(224, 27);
            this.tbStartDir.TabIndex = 15;
            // 
            // lblDirections
            // 
            this.lblDirections.Location = new System.Drawing.Point(73, 52);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(264, 25);
            this.lblDirections.TabIndex = 13;
            this.lblDirections.Text = "Select a file or folder for backup.";
            // 
            // gbLocal
            // 
            this.gbLocal.Controls.Add(this.Label2);
            this.gbLocal.Controls.Add(this.btnToChoose);
            this.gbLocal.Controls.Add(this.tbTargetDir);
            this.gbLocal.Enabled = false;
            this.gbLocal.Location = new System.Drawing.Point(77, 75);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(497, 97);
            this.gbLocal.TabIndex = 23;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "Local Storage";
            // 
            // btnGoPage_3
            // 
            this.btnGoPage_3.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGoPage_3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoPage_3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoPage_3.Location = new System.Drawing.Point(379, 561);
            this.btnGoPage_3.Name = "btnGoPage_3";
            this.btnGoPage_3.Size = new System.Drawing.Size(195, 58);
            this.btnGoPage_3.TabIndex = 24;
            this.btnGoPage_3.Text = "&Finish";
            this.btnGoPage_3.UseVisualStyleBackColor = false;
            this.btnGoPage_3.Click += new System.EventHandler(this.btnGoPage_3_Click);
            // 
            // cbLocal
            // 
            this.cbLocal.AutoSize = true;
            this.cbLocal.Location = new System.Drawing.Point(49, 113);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(22, 21);
            this.cbLocal.TabIndex = 25;
            this.cbLocal.UseVisualStyleBackColor = true;
            this.cbLocal.CheckedChanged += new System.EventHandler(this.cbLocal_CheckedChanged);
            // 
            // gbCloud
            // 
            this.gbCloud.Controls.Add(this.checkBox4);
            this.gbCloud.Controls.Add(this.checkBox3);
            this.gbCloud.Controls.Add(this.checkBox2);
            this.gbCloud.Controls.Add(this.checkBox1);
            this.gbCloud.Controls.Add(this.label3);
            this.gbCloud.Enabled = false;
            this.gbCloud.Location = new System.Drawing.Point(77, 189);
            this.gbCloud.Name = "gbCloud";
            this.gbCloud.Size = new System.Drawing.Size(497, 328);
            this.gbCloud.TabIndex = 26;
            this.gbCloud.TabStop = false;
            this.gbCloud.Text = "Cloud Storage";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(232, 168);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 23);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "iCloud";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(53, 168);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 23);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "DropBox";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(234, 116);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 23);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "OneDrive";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(53, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 23);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Google Drive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "* If you are not already logged into an account, you will be prompted to sign in." +
    "";
            // 
            // cbCloud
            // 
            this.cbCloud.AutoSize = true;
            this.cbCloud.Location = new System.Drawing.Point(49, 357);
            this.cbCloud.Name = "cbCloud";
            this.cbCloud.Size = new System.Drawing.Size(22, 21);
            this.cbCloud.TabIndex = 27;
            this.cbCloud.UseVisualStyleBackColor = true;
            this.cbCloud.CheckedChanged += new System.EventHandler(this.cbCloud_CheckedChanged);
            // 
            // gbPage_1
            // 
            this.gbPage_1.Controls.Add(this.btnGoPage_2);
            this.gbPage_1.Controls.Add(this.btnFromChoose);
            this.gbPage_1.Controls.Add(this.tbStartDir);
            this.gbPage_1.Controls.Add(this.lblDirections);
            this.gbPage_1.Location = new System.Drawing.Point(24, 29);
            this.gbPage_1.Name = "gbPage_1";
            this.gbPage_1.Size = new System.Drawing.Size(400, 319);
            this.gbPage_1.TabIndex = 28;
            this.gbPage_1.TabStop = false;
            // 
            // btnGoPage_2
            // 
            this.btnGoPage_2.Location = new System.Drawing.Point(216, 251);
            this.btnGoPage_2.Name = "btnGoPage_2";
            this.btnGoPage_2.Size = new System.Drawing.Size(151, 37);
            this.btnGoPage_2.TabIndex = 19;
            this.btnGoPage_2.Text = "&Next";
            this.btnGoPage_2.UseVisualStyleBackColor = true;
            this.btnGoPage_2.Click += new System.EventHandler(this.btnGoPage_2_Click);
            // 
            // btnGoPage_1
            // 
            this.btnGoPage_1.Location = new System.Drawing.Point(75, 575);
            this.btnGoPage_1.Name = "btnGoPage_1";
            this.btnGoPage_1.Size = new System.Drawing.Size(151, 37);
            this.btnGoPage_1.TabIndex = 20;
            this.btnGoPage_1.Text = "&Previous";
            this.btnGoPage_1.UseVisualStyleBackColor = true;
            // 
            // gbPage_2
            // 
            this.gbPage_2.Controls.Add(this.label1);
            this.gbPage_2.Controls.Add(this.btnGoPage_1);
            this.gbPage_2.Controls.Add(this.gbLocal);
            this.gbPage_2.Controls.Add(this.cbLocal);
            this.gbPage_2.Controls.Add(this.btnGoPage_3);
            this.gbPage_2.Controls.Add(this.cbCloud);
            this.gbPage_2.Controls.Add(this.gbCloud);
            this.gbPage_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPage_2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPage_2.Location = new System.Drawing.Point(479, 36);
            this.gbPage_2.Name = "gbPage_2";
            this.gbPage_2.Size = new System.Drawing.Size(689, 647);
            this.gbPage_2.TabIndex = 29;
            this.gbPage_2.TabStop = false;
            this.gbPage_2.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(176, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the storage location(s) for backup.";
            // 
            // gbPage_3
            // 
            this.gbPage_3.Controls.Add(this.button3);
            this.gbPage_3.Controls.Add(this.button2);
            this.gbPage_3.Controls.Add(this.label4);
            this.gbPage_3.Location = new System.Drawing.Point(24, 366);
            this.gbPage_3.Name = "gbPage_3";
            this.gbPage_3.Size = new System.Drawing.Size(389, 317);
            this.gbPage_3.TabIndex = 30;
            this.gbPage_3.TabStop = false;
            this.gbPage_3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create another backup";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Successful Backup! Thanks for using Quick-Backup.";
            // 
            // FormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 1036);
            this.Controls.Add(this.gbPage_3);
            this.Controls.Add(this.gbPage_2);
            this.Controls.Add(this.gbPage_1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUI";
            this.Text = "Create a new backup";
            this.Load += new System.EventHandler(this.FormUI_Load);
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            this.gbCloud.ResumeLayout(false);
            this.gbCloud.PerformLayout();
            this.gbPage_1.ResumeLayout(false);
            this.gbPage_1.PerformLayout();
            this.gbPage_2.ResumeLayout(false);
            this.gbPage_2.PerformLayout();
            this.gbPage_3.ResumeLayout(false);
            this.gbPage_3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnToChoose;
        internal System.Windows.Forms.Button btnFromChoose;
        internal System.Windows.Forms.TextBox tbTargetDir;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tbStartDir;
        internal System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.FolderBrowserDialog fbdStartDir;
        private System.Windows.Forms.FolderBrowserDialog fbdTargetDir;
        private System.Windows.Forms.GroupBox gbLocal;
        private System.Windows.Forms.Button btnGoPage_3;
        private System.Windows.Forms.CheckBox cbLocal;
        private System.Windows.Forms.GroupBox gbCloud;
        private System.Windows.Forms.CheckBox cbCloud;
        private System.Windows.Forms.GroupBox gbPage_1;
        private System.Windows.Forms.Button btnGoPage_2;
        private System.Windows.Forms.Button btnGoPage_1;
        private System.Windows.Forms.GroupBox gbPage_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPage_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.Label label1;
    }
}

