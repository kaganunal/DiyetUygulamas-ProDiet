namespace WFA_ProDiet.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCommercial = new System.Windows.Forms.Panel();
            this.pbCommercial = new System.Windows.Forms.PictureBox();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnShowPassword = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCommercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommercial)).BeginInit();
            this.pnlUserLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCommercial
            // 
            this.pnlCommercial.AutoScroll = true;
            this.pnlCommercial.Controls.Add(this.pbCommercial);
            this.pnlCommercial.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCommercial.Location = new System.Drawing.Point(0, 0);
            this.pnlCommercial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCommercial.Name = "pnlCommercial";
            this.pnlCommercial.Size = new System.Drawing.Size(420, 409);
            this.pnlCommercial.TabIndex = 0;
            // 
            // pbCommercial
            // 
            this.pbCommercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCommercial.Image = global::WFA_ProDiet.UI.Properties.Resources.HomePage2;
            this.pbCommercial.Location = new System.Drawing.Point(0, 0);
            this.pbCommercial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCommercial.Name = "pbCommercial";
            this.pbCommercial.Size = new System.Drawing.Size(398, 1605);
            this.pbCommercial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCommercial.TabIndex = 0;
            this.pbCommercial.TabStop = false;
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.Controls.Add(this.label3);
            this.pnlUserLogin.Controls.Add(this.btnLogin);
            this.pnlUserLogin.Controls.Add(this.txtEmail);
            this.pnlUserLogin.Controls.Add(this.txtPassword);
            this.pnlUserLogin.Controls.Add(this.btnShowPassword);
            this.pnlUserLogin.Controls.Add(this.label1);
            this.pnlUserLogin.Controls.Add(this.lnkCreateAccount);
            this.pnlUserLogin.Controls.Add(this.label2);
            this.pnlUserLogin.Location = new System.Drawing.Point(22, 207);
            this.pnlUserLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(314, 176);
            this.pnlUserLogin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hesabınız yok mu ?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 30;
            this.btnLogin.Location = new System.Drawing.Point(171, 84);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 80);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giris";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 8);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 47);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(191, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnShowPassword.IconColor = System.Drawing.Color.Black;
            this.btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPassword.IconSize = 25;
            this.btnShowPassword.Location = new System.Drawing.Point(271, 45);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(26, 31);
            this.btnShowPassword.TabIndex = 5;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // lnkCreateAccount
            // 
            this.lnkCreateAccount.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.lnkCreateAccount.AutoEllipsis = true;
            this.lnkCreateAccount.AutoSize = true;
            this.lnkCreateAccount.LinkColor = System.Drawing.Color.Teal;
            this.lnkCreateAccount.Location = new System.Drawing.Point(35, 140);
            this.lnkCreateAccount.Name = "lnkCreateAccount";
            this.lnkCreateAccount.Size = new System.Drawing.Size(102, 20);
            this.lnkCreateAccount.TabIndex = 3;
            this.lnkCreateAccount.TabStop = true;
            this.lnkCreateAccount.Text = "Hesap Oluştur";
            this.lnkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateAccount_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnlUserLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(426, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 409);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCommercial);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProDiet ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCommercial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCommercial)).EndInit();
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCommercial;
        private PictureBox pbCommercial;
        private LinkLabel lnkCreateAccount;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtPassword;
        private TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnLogin;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnShowPassword;
        private Panel pnlUserLogin;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}