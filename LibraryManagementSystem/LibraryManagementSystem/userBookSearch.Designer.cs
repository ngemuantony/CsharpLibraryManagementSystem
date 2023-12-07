namespace LibraryManagementSystem
{
    partial class userBookSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userBookSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usrBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.UserBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.UserBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.userBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.userBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.userBookSearchLblSearch = new System.Windows.Forms.Label();
            this.userBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.admBookSearchBtnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UserBookSearchBtnSearch);
            this.panel1.Controls.Add(this.UserBookSearchTbxQuery);
            this.panel1.Controls.Add(this.userBookSearchRbBoth);
            this.panel1.Controls.Add(this.userBookSearchRbAuthor);
            this.panel1.Controls.Add(this.userBookSearchRbTitle);
            this.panel1.Controls.Add(this.userBookSearchLblSearch);
            this.panel1.Controls.Add(this.userBookSearchDgv);
            this.panel1.Location = new System.Drawing.Point(43, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 722);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(982, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Issued Books";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.usrBookSearchBtnIssuedBooks_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(980, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.userBookSeacrhBtnChangePassword_Click);
            // 
            // usrBookSearchBtnLogout
            // 
            this.usrBookSearchBtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usrBookSearchBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usrBookSearchBtnLogout.ForeColor = System.Drawing.Color.Black;
            this.usrBookSearchBtnLogout.Location = new System.Drawing.Point(1022, 0);
            this.usrBookSearchBtnLogout.Name = "usrBookSearchBtnLogout";
            this.usrBookSearchBtnLogout.Size = new System.Drawing.Size(88, 42);
            this.usrBookSearchBtnLogout.TabIndex = 21;
            this.usrBookSearchBtnLogout.Text = "Logout";
            this.usrBookSearchBtnLogout.UseVisualStyleBackColor = false;
            this.usrBookSearchBtnLogout.Click += new System.EventHandler(this.UserBookSearchBtnLogout_Click);
            // 
            // UserBookSearchBtnSearch
            // 
            this.UserBookSearchBtnSearch.BackColor = System.Drawing.Color.Green;
            this.UserBookSearchBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchBtnSearch.ForeColor = System.Drawing.Color.White;
            this.UserBookSearchBtnSearch.Location = new System.Drawing.Point(460, 121);
            this.UserBookSearchBtnSearch.Name = "UserBookSearchBtnSearch";
            this.UserBookSearchBtnSearch.Size = new System.Drawing.Size(88, 33);
            this.UserBookSearchBtnSearch.TabIndex = 19;
            this.UserBookSearchBtnSearch.Text = "Search";
            this.UserBookSearchBtnSearch.UseVisualStyleBackColor = false;
            this.UserBookSearchBtnSearch.Click += new System.EventHandler(this.UserBookSearchBtnSearch_Click);
            // 
            // UserBookSearchTbxQuery
            // 
            this.UserBookSearchTbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBookSearchTbxQuery.Location = new System.Drawing.Point(246, 92);
            this.UserBookSearchTbxQuery.Name = "UserBookSearchTbxQuery";
            this.UserBookSearchTbxQuery.Size = new System.Drawing.Size(327, 23);
            this.UserBookSearchTbxQuery.TabIndex = 18;
            this.UserBookSearchTbxQuery.TextChanged += new System.EventHandler(this.UserBookSearchTbxQuery_TextChanged);
            // 
            // userBookSearchRbBoth
            // 
            this.userBookSearchRbBoth.AutoSize = true;
            this.userBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbBoth.Location = new System.Drawing.Point(364, 121);
            this.userBookSearchRbBoth.Name = "userBookSearchRbBoth";
            this.userBookSearchRbBoth.Size = new System.Drawing.Size(68, 35);
            this.userBookSearchRbBoth.TabIndex = 17;
            this.userBookSearchRbBoth.TabStop = true;
            this.userBookSearchRbBoth.Text = "Both";
            this.userBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbAuthor
            // 
            this.userBookSearchRbAuthor.AutoSize = true;
            this.userBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbAuthor.Location = new System.Drawing.Point(283, 121);
            this.userBookSearchRbAuthor.Name = "userBookSearchRbAuthor";
            this.userBookSearchRbAuthor.Size = new System.Drawing.Size(86, 35);
            this.userBookSearchRbAuthor.TabIndex = 16;
            this.userBookSearchRbAuthor.TabStop = true;
            this.userBookSearchRbAuthor.Text = "Author";
            this.userBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // userBookSearchRbTitle
            // 
            this.userBookSearchRbTitle.AutoSize = true;
            this.userBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchRbTitle.Location = new System.Drawing.Point(221, 121);
            this.userBookSearchRbTitle.Name = "userBookSearchRbTitle";
            this.userBookSearchRbTitle.Size = new System.Drawing.Size(67, 35);
            this.userBookSearchRbTitle.TabIndex = 15;
            this.userBookSearchRbTitle.TabStop = true;
            this.userBookSearchRbTitle.Text = "Title";
            this.userBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // userBookSearchLblSearch
            // 
            this.userBookSearchLblSearch.AutoSize = true;
            this.userBookSearchLblSearch.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBookSearchLblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userBookSearchLblSearch.Location = new System.Drawing.Point(137, 95);
            this.userBookSearchLblSearch.Name = "userBookSearchLblSearch";
            this.userBookSearchLblSearch.Size = new System.Drawing.Size(105, 24);
            this.userBookSearchLblSearch.TabIndex = 14;
            this.userBookSearchLblSearch.Text = "SEARCH:";
            // 
            // userBookSearchDgv
            // 
            this.userBookSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.userBookSearchDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userBookSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBookSearchDgv.Location = new System.Drawing.Point(157, 207);
            this.userBookSearchDgv.Name = "userBookSearchDgv";
            this.userBookSearchDgv.Size = new System.Drawing.Size(969, 481);
            this.userBookSearchDgv.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 75);
            this.label1.TabIndex = 25;
            this.label1.Text = "SEARCH BOOKS";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1194, -4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 46);
            this.button3.TabIndex = 72;
            this.button3.Text = "QUIT APP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // admBookSearchBtnBack
            // 
            this.admBookSearchBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admBookSearchBtnBack.ForeColor = System.Drawing.Color.White;
            this.admBookSearchBtnBack.Location = new System.Drawing.Point(2, -4);
            this.admBookSearchBtnBack.Name = "admBookSearchBtnBack";
            this.admBookSearchBtnBack.Size = new System.Drawing.Size(114, 39);
            this.admBookSearchBtnBack.TabIndex = 25;
            this.admBookSearchBtnBack.Text = "BACK";
            this.admBookSearchBtnBack.UseVisualStyleBackColor = false;
            this.admBookSearchBtnBack.Click += new System.EventHandler(this.admBookSearchBtnBack_Click);
            // 
            // userBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1352, 749);
            this.Controls.Add(this.admBookSearchBtnBack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrBookSearchBtnLogout);
            this.Controls.Add(this.panel1);
            this.Name = "userBookSearch";
            this.Text = "Search Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userBookSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBookSearchDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button usrBookSearchBtnLogout;
        private System.Windows.Forms.Button UserBookSearchBtnSearch;
        private System.Windows.Forms.TextBox UserBookSearchTbxQuery;
        private System.Windows.Forms.RadioButton userBookSearchRbBoth;
        private System.Windows.Forms.RadioButton userBookSearchRbAuthor;
        private System.Windows.Forms.RadioButton userBookSearchRbTitle;
        private System.Windows.Forms.Label userBookSearchLblSearch;
        private System.Windows.Forms.DataGridView userBookSearchDgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button admBookSearchBtnBack;
    }
}