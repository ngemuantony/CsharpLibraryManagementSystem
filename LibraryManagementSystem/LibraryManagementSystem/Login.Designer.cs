namespace LibraryManagementSystem
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginBtnSubmit = new System.Windows.Forms.Button();
            this.loginTbxPassword = new System.Windows.Forms.TextBox();
            this.loginTbxUserId = new System.Windows.Forms.TextBox();
            this.loginLblPassword = new System.Windows.Forms.Label();
            this.loginLblUserId = new System.Windows.Forms.Label();
            this.loginLblQuote = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.LoginBtnSubmit);
            this.panel1.Controls.Add(this.loginTbxPassword);
            this.panel1.Controls.Add(this.loginTbxUserId);
            this.panel1.Controls.Add(this.loginLblPassword);
            this.panel1.Controls.Add(this.loginLblUserId);
            this.panel1.Controls.Add(this.loginLblQuote);
            this.panel1.Location = new System.Drawing.Point(67, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 317);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(929, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 43);
            this.button1.TabIndex = 72;
            this.button1.Text = "QUIT APP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginBtnSubmit
            // 
            this.LoginBtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginBtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LoginBtnSubmit.ForeColor = System.Drawing.Color.Black;
            this.LoginBtnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoginBtnSubmit.Location = new System.Drawing.Point(410, 191);
            this.LoginBtnSubmit.Name = "LoginBtnSubmit";
            this.LoginBtnSubmit.Size = new System.Drawing.Size(74, 32);
            this.LoginBtnSubmit.TabIndex = 9;
            this.LoginBtnSubmit.Text = "LOGIN";
            this.LoginBtnSubmit.UseVisualStyleBackColor = false;
            this.LoginBtnSubmit.Click += new System.EventHandler(this.LoginBtnSubmit_Click);
            // 
            // loginTbxPassword
            // 
            this.loginTbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginTbxPassword.Location = new System.Drawing.Point(309, 130);
            this.loginTbxPassword.Name = "loginTbxPassword";
            this.loginTbxPassword.PasswordChar = '*';
            this.loginTbxPassword.Size = new System.Drawing.Size(294, 27);
            this.loginTbxPassword.TabIndex = 8;
            this.loginTbxPassword.TextChanged += new System.EventHandler(this.loginTbxPassword_TextChanged);
            // 
            // loginTbxUserId
            // 
            this.loginTbxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginTbxUserId.Location = new System.Drawing.Point(309, 63);
            this.loginTbxUserId.Name = "loginTbxUserId";
            this.loginTbxUserId.Size = new System.Drawing.Size(294, 27);
            this.loginTbxUserId.TabIndex = 7;
            this.loginTbxUserId.TextChanged += new System.EventHandler(this.loginTbxUserId_TextChanged);
            // 
            // loginLblPassword
            // 
            this.loginLblPassword.AutoSize = true;
            this.loginLblPassword.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.loginLblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginLblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginLblPassword.Location = new System.Drawing.Point(179, 135);
            this.loginLblPassword.Name = "loginLblPassword";
            this.loginLblPassword.Size = new System.Drawing.Size(110, 22);
            this.loginLblPassword.TabIndex = 6;
            this.loginLblPassword.Text = "Password :";
            // 
            // loginLblUserId
            // 
            this.loginLblUserId.AutoSize = true;
            this.loginLblUserId.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.loginLblUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginLblUserId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginLblUserId.Location = new System.Drawing.Point(179, 68);
            this.loginLblUserId.Name = "loginLblUserId";
            this.loginLblUserId.Size = new System.Drawing.Size(100, 22);
            this.loginLblUserId.TabIndex = 5;
            this.loginLblUserId.Text = "User ID :";
            // 
            // loginLblQuote
            // 
            this.loginLblQuote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginLblQuote.AutoSize = true;
            this.loginLblQuote.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLblQuote.ForeColor = System.Drawing.Color.White;
            this.loginLblQuote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginLblQuote.Location = new System.Drawing.Point(228, 22);
            this.loginLblQuote.Name = "loginLblQuote";
            this.loginLblQuote.Size = new System.Drawing.Size(472, 35);
            this.loginLblQuote.TabIndex = 3;
            this.loginLblQuote.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.loginLblQuote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLblQuote.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 72);
            this.label1.TabIndex = 11;
            this.label1.Text = "LOGIN";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1086, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1102, 542);
            this.MinimumSize = new System.Drawing.Size(450, 335);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLblQuote;
        private System.Windows.Forms.Button LoginBtnSubmit;
        private System.Windows.Forms.TextBox loginTbxPassword;
        private System.Windows.Forms.TextBox loginTbxUserId;
        private System.Windows.Forms.Label loginLblPassword;
        private System.Windows.Forms.Label loginLblUserId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

