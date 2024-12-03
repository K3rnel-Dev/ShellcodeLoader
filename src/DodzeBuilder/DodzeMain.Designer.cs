namespace DodzeBuilder
{
    partial class DodzeMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodzeMain));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.SelectFileBtn = new MetroFramework.Controls.MetroButton();
            this.HideFileChk = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.XorKeygen = new MetroFramework.Controls.MetroTextBox();
            this.BuildBtn = new MetroFramework.Controls.MetroButton();
            this.SelectIconBtn = new MetroFramework.Controls.MetroButton();
            this.SelectAssemblyBtn = new MetroFramework.Controls.MetroButton();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.AutorunChk = new MetroFramework.Controls.MetroCheckBox();
            this.MeltFileChk = new MetroFramework.Controls.MetroCheckBox();
            this.ObfuscateChk = new MetroFramework.Controls.MetroCheckBox();
            this.FilePathBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.DonutLabel = new System.Windows.Forms.Label();
            this.MetroFrameworkLabel = new System.Windows.Forms.Label();
            this.DnlibLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.XorKeygeneration = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(443, 284);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.DimGray;
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.SelectFileBtn);
            this.metroTabPage1.Controls.Add(this.HideFileChk);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.XorKeygen);
            this.metroTabPage1.Controls.Add(this.BuildBtn);
            this.metroTabPage1.Controls.Add(this.SelectIconBtn);
            this.metroTabPage1.Controls.Add(this.SelectAssemblyBtn);
            this.metroTabPage1.Controls.Add(this.IconBox);
            this.metroTabPage1.Controls.Add(this.AutorunChk);
            this.metroTabPage1.Controls.Add(this.MeltFileChk);
            this.metroTabPage1.Controls.Add(this.ObfuscateChk);
            this.metroTabPage1.Controls.Add(this.FilePathBox);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.ForeColor = System.Drawing.Color.White;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(435, 245);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "M A I N     |";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(344, 40);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(83, 24);
            this.SelectFileBtn.Style = MetroFramework.MetroColorStyle.White;
            this.SelectFileBtn.TabIndex = 14;
            this.SelectFileBtn.Text = "Choose";
            this.SelectFileBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // HideFileChk
            // 
            this.HideFileChk.AutoSize = true;
            this.HideFileChk.BackColor = System.Drawing.Color.Transparent;
            this.HideFileChk.CustomForeColor = true;
            this.HideFileChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideFileChk.Location = new System.Drawing.Point(248, 132);
            this.HideFileChk.Name = "HideFileChk";
            this.HideFileChk.Size = new System.Drawing.Size(66, 15);
            this.HideFileChk.Style = MetroFramework.MetroColorStyle.White;
            this.HideFileChk.TabIndex = 13;
            this.HideFileChk.Text = "HideFile";
            this.HideFileChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HideFileChk.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Encryption Key";
            // 
            // XorKeygen
            // 
            this.XorKeygen.CustomForeColor = true;
            this.XorKeygen.Location = new System.Drawing.Point(14, 93);
            this.XorKeygen.Name = "XorKeygen";
            this.XorKeygen.PromptText = "Key Xor";
            this.XorKeygen.ReadOnly = true;
            this.XorKeygen.Size = new System.Drawing.Size(397, 23);
            this.XorKeygen.Style = MetroFramework.MetroColorStyle.White;
            this.XorKeygen.TabIndex = 11;
            this.XorKeygen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XorKeygen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.XorKeygen.UseStyleColors = true;
            // 
            // BuildBtn
            // 
            this.BuildBtn.Location = new System.Drawing.Point(209, 160);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(212, 71);
            this.BuildBtn.Style = MetroFramework.MetroColorStyle.White;
            this.BuildBtn.TabIndex = 10;
            this.BuildBtn.Text = "BUILD";
            this.BuildBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // SelectIconBtn
            // 
            this.SelectIconBtn.Location = new System.Drawing.Point(98, 160);
            this.SelectIconBtn.Name = "SelectIconBtn";
            this.SelectIconBtn.Size = new System.Drawing.Size(105, 34);
            this.SelectIconBtn.Style = MetroFramework.MetroColorStyle.White;
            this.SelectIconBtn.TabIndex = 9;
            this.SelectIconBtn.Text = "select ico";
            this.SelectIconBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectIconBtn.Click += new System.EventHandler(this.SelectIconBtn_Click);
            // 
            // SelectAssemblyBtn
            // 
            this.SelectAssemblyBtn.Location = new System.Drawing.Point(98, 199);
            this.SelectAssemblyBtn.Name = "SelectAssemblyBtn";
            this.SelectAssemblyBtn.Size = new System.Drawing.Size(105, 32);
            this.SelectAssemblyBtn.Style = MetroFramework.MetroColorStyle.White;
            this.SelectAssemblyBtn.TabIndex = 8;
            this.SelectAssemblyBtn.Text = "select assembly";
            this.SelectAssemblyBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectAssemblyBtn.Click += new System.EventHandler(this.SelectAssemblyBtn_Click);
            // 
            // IconBox
            // 
            this.IconBox.BackColor = System.Drawing.Color.Transparent;
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconBox.Location = new System.Drawing.Point(14, 160);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(78, 71);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 7;
            this.IconBox.TabStop = false;
            // 
            // AutorunChk
            // 
            this.AutorunChk.AutoSize = true;
            this.AutorunChk.BackColor = System.Drawing.Color.Transparent;
            this.AutorunChk.CustomForeColor = true;
            this.AutorunChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorunChk.Location = new System.Drawing.Point(344, 132);
            this.AutorunChk.Name = "AutorunChk";
            this.AutorunChk.Size = new System.Drawing.Size(67, 15);
            this.AutorunChk.Style = MetroFramework.MetroColorStyle.White;
            this.AutorunChk.TabIndex = 6;
            this.AutorunChk.Text = "Autorun";
            this.AutorunChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AutorunChk.UseVisualStyleBackColor = false;
            // 
            // MeltFileChk
            // 
            this.MeltFileChk.AutoSize = true;
            this.MeltFileChk.BackColor = System.Drawing.Color.Transparent;
            this.MeltFileChk.CustomForeColor = true;
            this.MeltFileChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeltFileChk.Location = new System.Drawing.Point(155, 132);
            this.MeltFileChk.Name = "MeltFileChk";
            this.MeltFileChk.Size = new System.Drawing.Size(70, 15);
            this.MeltFileChk.Style = MetroFramework.MetroColorStyle.White;
            this.MeltFileChk.TabIndex = 5;
            this.MeltFileChk.Text = "Melt-File";
            this.MeltFileChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MeltFileChk.UseVisualStyleBackColor = false;
            // 
            // ObfuscateChk
            // 
            this.ObfuscateChk.AutoSize = true;
            this.ObfuscateChk.BackColor = System.Drawing.Color.Transparent;
            this.ObfuscateChk.CustomForeColor = true;
            this.ObfuscateChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObfuscateChk.Location = new System.Drawing.Point(13, 132);
            this.ObfuscateChk.Name = "ObfuscateChk";
            this.ObfuscateChk.Size = new System.Drawing.Size(121, 15);
            this.ObfuscateChk.Style = MetroFramework.MetroColorStyle.White;
            this.ObfuscateChk.TabIndex = 4;
            this.ObfuscateChk.Text = "Simple Obfuscator";
            this.ObfuscateChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ObfuscateChk.UseVisualStyleBackColor = false;
            // 
            // FilePathBox
            // 
            this.FilePathBox.AllowDrop = true;
            this.FilePathBox.CustomForeColor = true;
            this.FilePathBox.Location = new System.Drawing.Point(14, 41);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.PromptText = "File Path";
            this.FilePathBox.Size = new System.Drawing.Size(324, 23);
            this.FilePathBox.Style = MetroFramework.MetroColorStyle.White;
            this.FilePathBox.TabIndex = 3;
            this.FilePathBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FilePathBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FilePathBox.UseStyleColors = true;
            this.FilePathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePathBox_DragDrop);
            this.FilePathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilePathBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = ".NET - to shellcode";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage3.Controls.Add(this.DonutLabel);
            this.metroTabPage3.Controls.Add(this.MetroFrameworkLabel);
            this.metroTabPage3.Controls.Add(this.DnlibLabel);
            this.metroTabPage3.Controls.Add(this.label5);
            this.metroTabPage3.Controls.Add(this.GitLabel);
            this.metroTabPage3.Controls.Add(this.AuthorLabel);
            this.metroTabPage3.Controls.Add(this.groupBox1);
            this.metroTabPage3.Controls.Add(this.pictureBox1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(435, 245);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "A B O U T";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // DonutLabel
            // 
            this.DonutLabel.AutoSize = true;
            this.DonutLabel.BackColor = System.Drawing.Color.Transparent;
            this.DonutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonutLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DonutLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.DonutLabel.Location = new System.Drawing.Point(299, 214);
            this.DonutLabel.Name = "DonutLabel";
            this.DonutLabel.Size = new System.Drawing.Size(122, 17);
            this.DonutLabel.TabIndex = 9;
            this.DonutLabel.Text = "donut (TheWover)";
            this.DonutLabel.Click += new System.EventHandler(this.DonutLabel_Click);
            // 
            // MetroFrameworkLabel
            // 
            this.MetroFrameworkLabel.AutoSize = true;
            this.MetroFrameworkLabel.BackColor = System.Drawing.Color.Transparent;
            this.MetroFrameworkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MetroFrameworkLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MetroFrameworkLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.MetroFrameworkLabel.Location = new System.Drawing.Point(121, 214);
            this.MetroFrameworkLabel.Name = "MetroFrameworkLabel";
            this.MetroFrameworkLabel.Size = new System.Drawing.Size(164, 17);
            this.MetroFrameworkLabel.TabIndex = 8;
            this.MetroFrameworkLabel.Text = "MetroFramework (thielj)";
            this.MetroFrameworkLabel.Click += new System.EventHandler(this.MetroFrameworkLabel_Click);
            // 
            // DnlibLabel
            // 
            this.DnlibLabel.AutoSize = true;
            this.DnlibLabel.BackColor = System.Drawing.Color.Transparent;
            this.DnlibLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DnlibLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DnlibLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.DnlibLabel.Location = new System.Drawing.Point(11, 214);
            this.DnlibLabel.Name = "DnlibLabel";
            this.DnlibLabel.Size = new System.Drawing.Size(98, 17);
            this.DnlibLabel.TabIndex = 7;
            this.DnlibLabel.Text = "dnlib (0xd4d) ";
            this.DnlibLabel.Click += new System.EventHandler(this.DnlibLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Credits:";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.BackColor = System.Drawing.Color.Transparent;
            this.GitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.GitLabel.Location = new System.Drawing.Point(6, 146);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(144, 17);
            this.GitLabel.TabIndex = 5;
            this.GitLabel.Text = "Github: Kernel (click)";
            this.GitLabel.Click += new System.EventHandler(this.GitLabel_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.AuthorLabel.Location = new System.Drawing.Point(9, 122);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(131, 17);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author: K3rnel-Dev";
            this.AuthorLabel.Click += new System.EventHandler(this.AuthorLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(157, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 144);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DodzeBuilder.Properties.Resources.rambler;
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DodzeBuilder.Properties.Resources.ramlber_tppng;
            this.pictureBox2.Location = new System.Drawing.Point(214, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // XorKeygeneration
            // 
            this.XorKeygeneration.Enabled = true;
            this.XorKeygeneration.Tick += new System.EventHandler(this.XorKeygeneration_Tick);
            // 
            // DodzeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 370);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DodzeMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "D O D Z E  [道場] ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DodzeMain_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox FilePathBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox AutorunChk;
        private MetroFramework.Controls.MetroCheckBox MeltFileChk;
        private MetroFramework.Controls.MetroCheckBox ObfuscateChk;
        private System.Windows.Forms.PictureBox IconBox;
        private MetroFramework.Controls.MetroButton SelectIconBtn;
        private MetroFramework.Controls.MetroButton SelectAssemblyBtn;
        private MetroFramework.Controls.MetroButton BuildBtn;
        private MetroFramework.Controls.MetroCheckBox HideFileChk;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox XorKeygen;
        private MetroFramework.Controls.MetroButton SelectFileBtn;
        private System.Windows.Forms.Timer XorKeygeneration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DnlibLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.Label DonutLabel;
        private System.Windows.Forms.Label MetroFrameworkLabel;
        private System.Windows.Forms.Label label3;
    }
}

