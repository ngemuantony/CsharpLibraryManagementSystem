using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class admBookSearchForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public string username;
        public string password;

        public admBookSearchForm()
        {
            InitializeComponent();
            //MINIMIZING FUNCTIONALITY

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
        private void admBookSearchForm_Load(object sender, EventArgs e)
        {
            // Copy userid and pwd
            username = login.username;
            password = login.password;

            // Establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // On initialize display books table
            DisplayBooks();

            // Make read-only
            admBookSearchDgv.ReadOnly = true;

            // Select both radio button by default
            admBookSearchRbBoth.Checked = true;
        }

        private void admBookSearchBtnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admBookSearchBtnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string query;

                if (admBookSearchRbBoth.Checked)
                {
                    query = "SELECT b.BookID as 'Book ID', b.Title, b.Author, b.Publisher, b.YearOfPublication as 'Year of Pub', b.Genres, br.FullName as 'User Name', ib.DateIssued " +
                            "FROM Books b " +
                            "LEFT JOIN IssuedBooks ib ON ib.BookID = b.BookID " +
                            "LEFT JOIN Borrower br ON ib.BorrowerID = br.BorrowerID " +
                            "WHERE b.Title LIKE @searchQuery OR b.Author LIKE @searchQuery";
                }
                else if (admBookSearchRbTitle.Checked)
                {
                    query = "SELECT b.BookID as 'Book ID', b.Title, b.Author, b.Publisher, b.YearOfPublication as 'Year of Pub', b.Genres " +
                            "FROM Books b " +
                            "LEFT JOIN IssuedBooks ib ON ib.BookID = b.BookID " +
                            "LEFT JOIN Borrower br ON ib.BorrowerID = br.BorrowerID " +
                            "WHERE b.Title LIKE @searchQuery";
                }
                else
                {
                    query = "SELECT b.BookID as 'Book ID', b.Title, b.Author, b.Publisher, b.YearOfPublication as 'Year of Pub', b.Genres " +
                            "FROM Books b " +
                            "LEFT JOIN IssuedBooks ib ON ib.BookID = b.BookID " +
                            "LEFT JOIN Borrower br ON ib.BorrowerID = br.BorrowerID " +
                            "WHERE b.Author LIKE @searchQuery";
                }

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + admBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admBookSearchDgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void admBookSearchBtnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void DisplayBooks()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd = new SqlCommand("SELECT b.BookID as 'Book ID', b.Title, b.Author, b.Publisher, b.YearOfPublication as 'Year of Pub', b.Genres, br.FullName as 'User Name', ib.DateIssued " +
                                    "FROM Books b " +
                                    "LEFT JOIN IssuedBooks ib ON ib.BookID = b.BookID " +
                                    "LEFT JOIN Borrower br ON ib.BorrowerID = br.BorrowerID", con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                admBookSearchDgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
