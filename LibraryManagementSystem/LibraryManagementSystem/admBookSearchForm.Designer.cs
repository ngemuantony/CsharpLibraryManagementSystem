namespace LibraryManagementSystem
{
    partial class admBookSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admBookSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.admBookSearchTbxQuery = new System.Windows.Forms.TextBox();
            this.admBookSearchDgv = new System.Windows.Forms.DataGridView();
            this.admBookSearchRbBoth = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbTitle = new System.Windows.Forms.RadioButton();
            this.admBookSearchRbAuthor = new System.Windows.Forms.RadioButton();
            this.admBookSearchBtnSearch = new System.Windows.Forms.Button();
            this.admBookSearchBtnLogout = new System.Windows.Forms.Button();
            this.admBookSearchBtnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(106, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH:";
            // 
            // admBookSearchTbxQuery
            // 
            this.admBookSearchTbxQuery.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchTbxQuery.Location = new System.Drawing.Point(181, 148);
            this.admBookSearchTbxQuery.Name = "admBookSearchTbxQuery";
            this.admBookSearchTbxQuery.Size = new System.Drawing.Size(212, 25);
            this.admBookSearchTbxQuery.TabIndex = 1;
            // 
            // admBookSearchDgv
            // 
            this.admBookSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admBookSearchDgv.Location = new System.Drawing.Point(85, 259);
            this.admBookSearchDgv.Name = "admBookSearchDgv";
            this.admBookSearchDgv.Size = new System.Drawing.Size(1059, 335);
            this.admBookSearchDgv.TabIndex = 2;
            // 
            // admBookSearchRbBoth
            // 
            this.admBookSearchRbBoth.AutoSize = true;
            this.admBookSearchRbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbBoth.Location = new System.Drawing.Point(164, 198);
            this.admBookSearchRbBoth.Name = "admBookSearchRbBoth";
            this.admBookSearchRbBoth.Size = new System.Drawing.Size(137, 20);
            this.admBookSearchRbBoth.TabIndex = 3;
            this.admBookSearchRbBoth.TabStop = true;
            this.admBookSearchRbBoth.Text = "SEARCH BOTH:";
            this.admBookSearchRbBoth.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbTitle
            // 
            this.admBookSearchRbTitle.AutoSize = true;
            this.admBookSearchRbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbTitle.ForeColor = System.Drawing.Color.Green;
            this.admBookSearchRbTitle.Location = new System.Drawing.Point(308, 198);
            this.admBookSearchRbTitle.Name = "admBookSearchRbTitle";
            this.admBookSearchRbTitle.Size = new System.Drawing.Size(161, 20);
            this.admBookSearchRbTitle.TabIndex = 4;
            this.admBookSearchRbTitle.TabStop = true;
            this.admBookSearchRbTitle.Text = "SEARCH BY TITLE:";
            this.admBookSearchRbTitle.UseVisualStyleBackColor = true;
            // 
            // admBookSearchRbAuthor
            // 
            this.admBookSearchRbAuthor.AutoSize = true;
            this.admBookSearchRbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admBookSearchRbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admBookSearchRbAuthor.Location = new System.Drawing.Point(468, 198);
            this.admBookSearchRbAuthor.Name = "admBookSearchRbAuthor";
            this.admBookSearchRbAuthor.Size = new System.Drawing.Size(183, 20);
            this.admBookSearchRbAuthor.TabIndex = 5;
            this.admBookSearchRbAuthor.TabStop = true;
            this.admBookSearchRbAuthor.Text = "SEARCH BY AUTHOR:";
            this.admBookSearchRbAuthor.UseVisualStyleBackColor = true;
            // 
            // admBookSearchBtnSearch
            // 
            this.admBookSearchBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.admBookSearchBtnSearch.ForeColor = System.Drawing.Color.White;
            this.admBookSearchBtnSearch.Location = new System.Drawing.Point(667, 175);
            this.admBookSearchBtnSearch.Name = "admBookSearchBtnSearch";
            this.admBookSearchBtnSearch.Size = new System.Drawing.Size(114, 39);
            this.admBookSearchBtnSearch.TabIndex = 6;
            this.admBookSearchBtnSearch.Text = "SEARCH";
            this.admBookSearchBtnSearch.UseVisualStyleBackColor = false;
            this.admBookSearchBtnSearch.Click += new System.EventHandler(this.admBookSearchBtnSearch_Click_1);
            // 
            // admBookSearchBtnLogout
            // 
            this.admBookSearchBtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admBookSearchBtnLogout.ForeColor = System.Drawing.Color.White;
            this.admBookSearchBtnLogout.Location = new System.Drawing.Point(1120, 61);
            this.admBookSearchBtnLogout.Name = "admBookSearchBtnLogout";
            this.admBookSearchBtnLogout.Size = new System.Drawing.Size(114, 39);
            this.admBookSearchBtnLogout.TabIndex = 7;
            this.admBookSearchBtnLogout.Text = "LOGOUT";
            this.admBookSearchBtnLogout.UseVisualStyleBackColor = false;
            this.admBookSearchBtnLogout.Click += new System.EventHandler(this.admBookSearchBtnLogout_Click_1);
            // 
            // admBookSearchBtnBack
            // 
            this.admBookSearchBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.admBookSearchBtnBack.ForeColor = System.Drawing.Color.White;
            this.admBookSearchBtnBack.Location = new System.Drawing.Point(1, 61);
            this.admBookSearchBtnBack.Name = "admBookSearchBtnBack";
            this.admBookSearchBtnBack.Size = new System.Drawing.Size(114, 39);
            this.admBookSearchBtnBack.TabIndex = 8;
            this.admBookSearchBtnBack.Text = "BACK";
            this.admBookSearchBtnBack.UseVisualStyleBackColor = false;
            this.admBookSearchBtnBack.Click += new System.EventHandler(this.admBookSearchBtnBack_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "ADMINISTRATOR BOOK SEARCH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // admBookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1346, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admBookSearchBtnBack);
            this.Controls.Add(this.admBookSearchBtnLogout);
            this.Controls.Add(this.admBookSearchBtnSearch);
            this.Controls.Add(this.admBookSearchRbAuthor);
            this.Controls.Add(this.admBookSearchRbTitle);
            this.Controls.Add(this.admBookSearchRbBoth);
            this.Controls.Add(this.admBookSearchDgv);
            this.Controls.Add(this.admBookSearchTbxQuery);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1362, 850);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "admBookSearchForm";
            this.Text = "ADMIN BOOK SEARCH";
            this.Load += new System.EventHandler(this.admBookSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admBookSearchDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admBookSearchTbxQuery;
        private System.Windows.Forms.DataGridView admBookSearchDgv;
        private System.Windows.Forms.RadioButton admBookSearchRbBoth;
        private System.Windows.Forms.RadioButton admBookSearchRbTitle;
        private System.Windows.Forms.RadioButton admBookSearchRbAuthor;
        private System.Windows.Forms.Button admBookSearchBtnSearch;
        private System.Windows.Forms.Button admBookSearchBtnLogout;
        private System.Windows.Forms.Button admBookSearchBtnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}