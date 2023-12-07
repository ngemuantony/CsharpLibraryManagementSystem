using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class admReturn : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public admReturn()
        {
            InitializeComponent();
            ControlBox = false; // Disable the control box (including the form icon and system menu)
            FormClosing += LibraryMembers_FormClosing;
        }
        private void LibraryMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the close reason is user-initiated (X button)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the form closing event
                                 // You can minimize the form instead if you want
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void admReturn_Load(object sender, EventArgs e)
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // display table
            displayIssueBooks();
        }

        // clear text boxes
        private void clear()
        {
            admReturnTbxSearchQuery.Text = string.Empty;
            admReturnTbxUserID.Text = string.Empty;
            amdReturnTbxBookID.Text = string.Empty;

            admReturnBooksLblFine.Text = string.Empty;
        }

        // display table
        public void displayIssueBooks()
        {
            // on initialize display books table
            cmd = new SqlCommand("SELECT IssuedBooks.BookID as 'Book ID', Borrower.BorrowerID as 'Borrower ID', " +
                                           "Books.Title as 'Title', Borrower.FullName as 'Borrower Name', " +
                                           "IssuedBooks.DateIssued as 'Date Issued', IssuedBooks.ReturnDate as 'Return Date' " +
                                           "FROM IssuedBooks " +
                                           "INNER JOIN Books ON IssuedBooks.BookID = Books.BookID " +
                                           "INNER JOIN Borrower ON IssuedBooks.BorrowerID = Borrower.BorrowerID", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            admReturnDgvTable.DataSource = ds.Tables[0];
            admReturnDgvTable.ReadOnly = true;
        }

        // cell click functionality
        private void admReturnDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // not a column header
            if (e.RowIndex != -1 && e.RowIndex != admReturnDgvTable.Rows.Count - 1)
            {
                // Use safer conversion using TryParse
                if (int.TryParse(admReturnDgvTable.Rows[e.RowIndex].Cells[2].Value?.ToString(), out int book_id))
                {
                    int user_id = Convert.ToInt32(admReturnDgvTable.Rows[e.RowIndex].Cells[0].Value);

                    amdReturnTbxBookID.Text = Convert.ToString(book_id);
                    admReturnTbxUserID.Text = Convert.ToString(user_id);

                    // calculate fine too
                    int fine = 0;
                    int days_passed = Convert.ToInt32(admReturnDgvTable.Rows[e.RowIndex].Cells[5].Value);

                    if (days_passed > 15)
                    {
                        fine = days_passed - 15;
                    }

                    admReturnBooksLblFine.Text = Convert.ToString(fine + " Rs.");
                }
                else
                {
                    MessageBox.Show("Invalid Book ID format.");
                }
            }
        }

        // SEARCH BUTTON
        private void admReturnBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            try
            {
                if (admReturnTbxSearchQuery.Text == string.Empty)
                {
                    displayIssueBooks();
                }
                else
                {
                    cmd = new SqlCommand("SELECT IssuedBooks.BorrowerID as 'User ID', Borrower.FullName as 'Name', " +
                                        "IssuedBooks.BookID as 'Book ID', Books.Title as 'Title', " +
                                        "IssuedBooks.DateIssued as 'Date Issued', " +
                                        "DATEDIFF(day, IssuedBooks.DateIssued, CONVERT(date, GETDATE())) as 'Days Passed' " +
                                        "FROM IssuedBooks " +
                                        "INNER JOIN Books ON IssuedBooks.BookID = Books.BookID " +
                                        "INNER JOIN Borrower ON IssuedBooks.BorrowerID = Borrower.BorrowerID " +
                                        "WHERE IssuedBooks.BookID = @searchQuery OR IssuedBooks.BorrowerID = @searchQuery", con);

                    cmd.Parameters.AddWithValue("@searchQuery", Convert.ToInt32(admReturnTbxSearchQuery.Text));

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    admReturnDgvTable.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // RETURN BUTTON CLICK
        private void admReturnBtnReturn_Click(object sender, EventArgs e)
        {
            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // variables
            int book_id = 0;
            int user_id = 0;
            bool preliminaryAcceptedState = true;

            // check values
            try
            {
                book_id = int.Parse(amdReturnTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an integer.");
                preliminaryAcceptedState = false;
            }
            try
            {
                user_id = int.Parse(admReturnTbxUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an integer.");
                preliminaryAcceptedState = false;
            }

            // delete record from the db
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM IssuedBooks WHERE BookID = @book_id AND BorrowerID = @user_id", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    int result = cmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Please enter a valid User ID and Book ID.\nInvalid Input.");
                    }

                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully returned.");
                        clear();
                        displayIssueBooks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Internal system error.\nError: {ex.Message}");
                }
            }
        }

        private void admReturnBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admReturnBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }
    }
}
