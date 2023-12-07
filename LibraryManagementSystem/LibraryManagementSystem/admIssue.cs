using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class admIssue : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public admIssue()
        {
            InitializeComponent();
            ControlBox = false;
            FormClosing += LibraryMembers_FormClosing;
        }

        private void LibraryMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void admIssue_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            display();
            admIssueRbBoth.Select();
        }

        public void display()
        {
            cmd = new SqlCommand("SELECT BookID as 'Book ID', Title, Author, Publisher, YearOfPublication as 'Y.O.P', Genres FROM Books WHERE BookID NOT IN (SELECT BookID FROM IssuedBooks)", con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            admIssueDgvTable.DataSource = ds.Tables[0];
            admIssueDgvTable.ReadOnly = true;
        }

        public void clearFields()
        {
            admIssueTbxSearchQuery.Text = string.Empty;
            admIssueTbxUserID.Text = string.Empty;
            amdIssueTbxBookID.Text = string.Empty;
        }

        private void admIssueDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != admIssueDgvTable.Rows.Count - 1)
            {
                amdIssueTbxBookID.Text = Convert.ToString(admIssueDgvTable.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void admIssueBtnIssue_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            int user_id = 0;
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            try
            {
                user_id = int.Parse(admIssueTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an integer.");
                preliminaryAcceptedState = false;
            }
            try
            {
                book_id = int.Parse(amdIssueTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an integer.");
                preliminaryAcceptedState = false;
            }

            cmd = new SqlCommand("SELECT * FROM IssuedBooks WHERE BorrowerID = @Borrower_ID AND ReturnDate IS NULL", con);
            cmd.Parameters.AddWithValue("@Borrower_ID", user_id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int issuedBooksCount = ds.Tables[0].Rows.Count;

            if (issuedBooksCount >= 2)
            {
                MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
                preliminaryAcceptedState = false;
            }

            cmd = new SqlCommand("SELECT * FROM IssuedBooks WHERE BorrowerID = @user_id AND BookID = @book_id AND ReturnDate IS NULL", con);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            int existingIssueCount = ds1.Tables[0].Rows.Count;

            if (existingIssueCount > 0)
            {
                MessageBox.Show("The book has already been issued to this user.\nCannot issue the book again.");
                preliminaryAcceptedState = false;
            }

            if (preliminaryAcceptedState)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO IssuedBooks (BookID, BorrowerID, ReturnDate) VALUES (@book_id, @user_id, NULL)", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully issued.");
                        display();
                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error issuing the book: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        private void admIssueBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            string searchQuery = "%" + admIssueTbxSearchQuery.Text + "%";

            if (admIssueRbBoth.Checked == true)
            {
                cmd = new SqlCommand("SELECT BookID as 'Book ID', Title, Author, Publisher, YearOfPublication as 'Y.O.P', Genres FROM Books WHERE (Title LIKE @searchQuery OR Author LIKE @searchQuery) AND BookID NOT IN (SELECT BookID FROM IssuedBooks)", con);
                cmd.Parameters.AddWithValue("@searchQuery", searchQuery);
            }
            else if (admIssueRbTitle.Checked == true)
            {
                cmd = new SqlCommand("SELECT BookID as 'Book ID', Title, Author, Publisher, YearOfPublication as 'Y.O.P', Genres FROM Books WHERE Title LIKE @searchQuery AND BookID NOT IN (SELECT BookID FROM IssuedBooks)", con);
                cmd.Parameters.AddWithValue("@searchQuery", searchQuery);
            }
            else if (admIssueRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("SELECT BookID as 'Book ID', Title, Author, Publisher, YearOfPublication as 'Y.O.P', Genres FROM Books WHERE Author LIKE @searchQuery AND BookID NOT IN (SELECT BookID FROM IssuedBooks)", con);
                cmd.Parameters.AddWithValue("@searchQuery", searchQuery);
            }

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            admIssueDgvTable.DataSource = ds.Tables[0];
        }

        private void admIssueBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admIssueBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }
    }
}
