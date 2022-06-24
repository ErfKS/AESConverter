namespace AESConverter
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
            this.SearchForExprotAES = new System.Windows.Forms.Button();
            this.txtPathForSaveAES_File = new System.Windows.Forms.TextBox();
            this.SaveAES = new System.Windows.Forms.Button();
            this.TxtSaveFileConvertToBase = new System.Windows.Forms.TextBox();
            this.LblErrorConvertToAES = new System.Windows.Forms.Label();
            this.LblErrorConvertToBase = new System.Windows.Forms.Label();
            this.LoadAES = new System.Windows.Forms.Button();
            this.SetUnsafeFilePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLoadFileConvertToBase = new System.Windows.Forms.TextBox();
            this.SaveUnsafeFile = new System.Windows.Forms.Button();
            this.TxtLoadFile = new System.Windows.Forms.TextBox();
            this.SearchForInportFileAES = new System.Windows.Forms.Button();
            this.SetPasswordFile = new System.Windows.Forms.TextBox();
            this.TxtPasswordLoadFileConvertToBase = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchForExprotAES
            // 
            this.SearchForExprotAES.Location = new System.Drawing.Point(226, 75);
            this.SearchForExprotAES.Name = "SearchForExprotAES";
            this.SearchForExprotAES.Size = new System.Drawing.Size(75, 23);
            this.SearchForExprotAES.TabIndex = 0;
            this.SearchForExprotAES.Text = "...جست و جو";
            this.SearchForExprotAES.UseVisualStyleBackColor = true;
            this.SearchForExprotAES.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPathForSaveAES_File
            // 
            this.txtPathForSaveAES_File.Location = new System.Drawing.Point(12, 75);
            this.txtPathForSaveAES_File.Name = "txtPathForSaveAES_File";
            this.txtPathForSaveAES_File.Size = new System.Drawing.Size(208, 20);
            this.txtPathForSaveAES_File.TabIndex = 1;
            this.txtPathForSaveAES_File.Text = "AES مسیر خروجی گرفتن به فایل";
            // 
            // SaveAES
            // 
            this.SaveAES.Location = new System.Drawing.Point(226, 104);
            this.SaveAES.Name = "SaveAES";
            this.SaveAES.Size = new System.Drawing.Size(75, 23);
            this.SaveAES.TabIndex = 2;
            this.SaveAES.Text = "ذخیره";
            this.SaveAES.UseVisualStyleBackColor = true;
            this.SaveAES.Click += new System.EventHandler(this.SaveAES_Click);
            // 
            // TxtSaveFileConvertToBase
            // 
            this.TxtSaveFileConvertToBase.Location = new System.Drawing.Point(12, 248);
            this.TxtSaveFileConvertToBase.Name = "TxtSaveFileConvertToBase";
            this.TxtSaveFileConvertToBase.Size = new System.Drawing.Size(208, 20);
            this.TxtSaveFileConvertToBase.TabIndex = 3;
            this.TxtSaveFileConvertToBase.Text = "مسیر خروجی گرفتن به فایل اصلی";
            // 
            // LblErrorConvertToAES
            // 
            this.LblErrorConvertToAES.AutoSize = true;
            this.LblErrorConvertToAES.BackColor = System.Drawing.SystemColors.Control;
            this.LblErrorConvertToAES.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblErrorConvertToAES.Location = new System.Drawing.Point(9, 143);
            this.LblErrorConvertToAES.Name = "LblErrorConvertToAES";
            this.LblErrorConvertToAES.Size = new System.Drawing.Size(21, 13);
            this.LblErrorConvertToAES.TabIndex = 4;
            this.LblErrorConvertToAES.Text = "asf";
            // 
            // LblErrorConvertToBase
            // 
            this.LblErrorConvertToBase.AutoSize = true;
            this.LblErrorConvertToBase.Location = new System.Drawing.Point(12, 312);
            this.LblErrorConvertToBase.Name = "LblErrorConvertToBase";
            this.LblErrorConvertToBase.Size = new System.Drawing.Size(15, 13);
            this.LblErrorConvertToBase.TabIndex = 5;
            this.LblErrorConvertToBase.Text = "sf";
            // 
            // LoadAES
            // 
            this.LoadAES.Location = new System.Drawing.Point(226, 220);
            this.LoadAES.Name = "LoadAES";
            this.LoadAES.Size = new System.Drawing.Size(75, 23);
            this.LoadAES.TabIndex = 6;
            this.LoadAES.Text = "...جست و جو";
            this.LoadAES.UseVisualStyleBackColor = true;
            this.LoadAES.Click += new System.EventHandler(this.LoadAES_Click);
            // 
            // SetUnsafeFilePath
            // 
            this.SetUnsafeFilePath.Location = new System.Drawing.Point(226, 249);
            this.SetUnsafeFilePath.Name = "SetUnsafeFilePath";
            this.SetUnsafeFilePath.Size = new System.Drawing.Size(75, 23);
            this.SetUnsafeFilePath.TabIndex = 7;
            this.SetUnsafeFilePath.Text = "...جست و جو";
            this.SetUnsafeFilePath.UseVisualStyleBackColor = true;
            this.SetUnsafeFilePath.Click += new System.EventHandler(this.SetUnsafeFilePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "AES تبدیل به فایل ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "تبدیل به فایل عادی";
            // 
            // TxtLoadFileConvertToBase
            // 
            this.TxtLoadFileConvertToBase.Location = new System.Drawing.Point(12, 222);
            this.TxtLoadFileConvertToBase.Name = "TxtLoadFileConvertToBase";
            this.TxtLoadFileConvertToBase.Size = new System.Drawing.Size(208, 20);
            this.TxtLoadFileConvertToBase.TabIndex = 10;
            this.TxtLoadFileConvertToBase.Text = "مسیر لود کردن فایل";
            // 
            // SaveUnsafeFile
            // 
            this.SaveUnsafeFile.Location = new System.Drawing.Point(226, 278);
            this.SaveUnsafeFile.Name = "SaveUnsafeFile";
            this.SaveUnsafeFile.Size = new System.Drawing.Size(75, 23);
            this.SaveUnsafeFile.TabIndex = 11;
            this.SaveUnsafeFile.Text = "ذخیره";
            this.SaveUnsafeFile.UseVisualStyleBackColor = true;
            this.SaveUnsafeFile.Click += new System.EventHandler(this.SaveUnsafeFile_Click);
            // 
            // TxtLoadFile
            // 
            this.TxtLoadFile.Location = new System.Drawing.Point(12, 49);
            this.TxtLoadFile.Name = "TxtLoadFile";
            this.TxtLoadFile.Size = new System.Drawing.Size(208, 20);
            this.TxtLoadFile.TabIndex = 12;
            this.TxtLoadFile.Text = "مسیر ورودی فایل";
            // 
            // SearchForInportFileAES
            // 
            this.SearchForInportFileAES.Location = new System.Drawing.Point(226, 46);
            this.SearchForInportFileAES.Name = "SearchForInportFileAES";
            this.SearchForInportFileAES.Size = new System.Drawing.Size(75, 23);
            this.SearchForInportFileAES.TabIndex = 13;
            this.SearchForInportFileAES.Text = "...جست و جو";
            this.SearchForInportFileAES.UseVisualStyleBackColor = true;
            this.SearchForInportFileAES.Click += new System.EventHandler(this.SearchForInportFileAES_Click);
            // 
            // SetPasswordFile
            // 
            this.SetPasswordFile.Location = new System.Drawing.Point(12, 107);
            this.SetPasswordFile.Name = "SetPasswordFile";
            this.SetPasswordFile.Size = new System.Drawing.Size(208, 20);
            this.SetPasswordFile.TabIndex = 14;
            this.SetPasswordFile.Text = "رمز";
            // 
            // TxtPasswordLoadFileConvertToBase
            // 
            this.TxtPasswordLoadFileConvertToBase.Location = new System.Drawing.Point(12, 280);
            this.TxtPasswordLoadFileConvertToBase.Name = "TxtPasswordLoadFileConvertToBase";
            this.TxtPasswordLoadFileConvertToBase.Size = new System.Drawing.Size(208, 20);
            this.TxtPasswordLoadFileConvertToBase.TabIndex = 15;
            this.TxtPasswordLoadFileConvertToBase.Text = "رمز";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtPasswordLoadFileConvertToBase);
            this.Controls.Add(this.SetPasswordFile);
            this.Controls.Add(this.SearchForInportFileAES);
            this.Controls.Add(this.TxtLoadFile);
            this.Controls.Add(this.SaveUnsafeFile);
            this.Controls.Add(this.TxtLoadFileConvertToBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetUnsafeFilePath);
            this.Controls.Add(this.LoadAES);
            this.Controls.Add(this.LblErrorConvertToBase);
            this.Controls.Add(this.LblErrorConvertToAES);
            this.Controls.Add(this.TxtSaveFileConvertToBase);
            this.Controls.Add(this.SaveAES);
            this.Controls.Add(this.txtPathForSaveAES_File);
            this.Controls.Add(this.SearchForExprotAES);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AESConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchForExprotAES;
        private System.Windows.Forms.TextBox txtPathForSaveAES_File;
        private System.Windows.Forms.Button SaveAES;
        private System.Windows.Forms.TextBox TxtSaveFileConvertToBase;
        private System.Windows.Forms.Label LblErrorConvertToAES;
        private System.Windows.Forms.Label LblErrorConvertToBase;
        private System.Windows.Forms.Button LoadAES;
        private System.Windows.Forms.Button SetUnsafeFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLoadFileConvertToBase;
        private System.Windows.Forms.Button SaveUnsafeFile;
        private System.Windows.Forms.TextBox TxtLoadFile;
        private System.Windows.Forms.Button SearchForInportFileAES;
        private System.Windows.Forms.TextBox SetPasswordFile;
        private System.Windows.Forms.TextBox TxtPasswordLoadFileConvertToBase;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

