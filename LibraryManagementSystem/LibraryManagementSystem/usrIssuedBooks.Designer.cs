namespace LibraryManagementSystem
{
    partial class usrIssuedBooks
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
            this.usrIssuedBooksBtnBack = new System.Windows.Forms.Button();
            this.usrIssuedBooksDgvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usrIssuedBooksDgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // usrIssuedBooksBtnBack
            // 
            this.usrIssuedBooksBtnBack.BackColor = System.Drawing.Color.Maroon;
            this.usrIssuedBooksBtnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrIssuedBooksBtnBack.ForeColor = System.Drawing.Color.White;
            this.usrIssuedBooksBtnBack.Location = new System.Drawing.Point(-2, -4);
            this.usrIssuedBooksBtnBack.Name = "usrIssuedBooksBtnBack";
            this.usrIssuedBooksBtnBack.Size = new System.Drawing.Size(99, 34);
            this.usrIssuedBooksBtnBack.TabIndex = 1;
            this.usrIssuedBooksBtnBack.Text = "BACK:";
            this.usrIssuedBooksBtnBack.UseVisualStyleBackColor = false;
            this.usrIssuedBooksBtnBack.Click += new System.EventHandler(this.usrIssuedBooksBtnBack_Click);
            // 
            // usrIssuedBooksDgvBooks
            // 
            this.usrIssuedBooksDgvBooks.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.usrIssuedBooksDgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usrIssuedBooksDgvBooks.Location = new System.Drawing.Point(-2, 66);
            this.usrIssuedBooksDgvBooks.Name = "usrIssuedBooksDgvBooks";
            this.usrIssuedBooksDgvBooks.Size = new System.Drawing.Size(1360, 581);
            this.usrIssuedBooksDgvBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "All ISSUED BOOKS REPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 702);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CREATED BY: ANTONY NGEMU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 727);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONTACT:muleiantony98gmail.com";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1125, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1217, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 39);
            this.button2.TabIndex = 72;
            this.button2.Text = "QUIT APP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usrIssuedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrIssuedBooksDgvBooks);
            this.Controls.Add(this.usrIssuedBooksBtnBack);
            this.Name = "usrIssuedBooks";
            this.Text = "USER ISSUE BOOK";
            this.Load += new System.EventHandler(this.usrIssuedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usrIssuedBooksDgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button usrIssuedBooksBtnBack;
        private System.Windows.Forms.DataGridView usrIssuedBooksDgvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}