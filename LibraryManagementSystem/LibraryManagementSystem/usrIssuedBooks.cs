using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class usrIssuedBooks : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public usrIssuedBooks()
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
        private void usrIssuedBooks_Load(object sender, EventArgs e)
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on initialize display books table
            cmd = new SqlCommand("SELECT DateIssued as 'Date Issued', DATEDIFF(day, DateIssued, CONVERT(date, GETDATE())) as 'Total days passed', " +
                                "IssuedBooks.BookID as 'Book ID', Title as 'Title', Author as 'Author', Publisher as 'Publisher', " +
                                "YearOfPublication as 'Year of Publication', Genres as 'Genres', " +
                                "IssuedBooks.BorrowerID, Borrower.FullName as 'Borrower Name', Borrower.UserAddress as 'Address', Borrower.Phone " +
                                "FROM IssuedBooks " +
                                "INNER JOIN Books ON IssuedBooks.BookID = Books.BookID " +
                                "INNER JOIN Borrower ON IssuedBooks.BorrowerID = Borrower.BorrowerID " +
                                "ORDER BY IssuedBooks.BorrowerID", con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            usrIssuedBooksDgvBooks.DataSource = ds.Tables[0];
            usrIssuedBooksDgvBooks.ReadOnly = true;
        }

        private void usrIssuedBooksBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            userBookSearch ubs = new userBookSearch();
            ubs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            Application.Exit();
        }
    }
    
}
