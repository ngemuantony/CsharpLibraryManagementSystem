using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class userBookSearch : Form
    {
        SqlConnection con;
        SqlCommand cmd ;

        // userid and pwd
        public string username;
        public string password;

        private void userBookSearch_Load(object sender, EventArgs e)
        {
            // copy userid and pwd
            username = login.username;
            password = login.password;

            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on intialise display books table
            cmd = new SqlCommand("select BookID as 'Book ID', Title as 'Title', Author as 'Author', Publisher as 'Publisher', YearOfPublication as 'Y.O.P', Genres as 'Genres' from Books order by BookID asc", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            userBookSearchDgv.DataSource = ds.Tables[0];

            // make dgv read only
            userBookSearchDgv.ReadOnly = true;

            // select both radio button by default
            userBookSearchRbBoth.Select();
        }

        private void UserBookSearchBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if(userBookSearchRbBoth.Checked == true)
            {
                cmd = new SqlCommand("select BookID as 'Book ID', Title as 'Title', Author as 'Author', Publisher as 'Publisher', YearOfPublication as 'Y.O.P', Genres as 'Genres' from Books where Title like @searchQuery or Author like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                userBookSearchDgv.DataSource = ds.Tables[0];
            }
            else if (userBookSearchRbTitle.Checked == true)
            {
                cmd = new SqlCommand("select BookID as 'Book ID', title as 'Title', Author as 'Author', Publisher as 'Publisher', YearOfPublication as 'Y.O.P', Genres as 'Genres' from Books where Title like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                userBookSearchDgv.DataSource = ds.Tables[0];
            }
            else if(userBookSearchRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("select BookID as 'Book ID', Title as 'Title', Author as 'Author', Publisher as 'Publisher', YearOfPublication as 'Y.O.P', Genres as 'Genres' from Books where Author like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + UserBookSearchTbxQuery.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                userBookSearchDgv.DataSource = ds.Tables[0];
            }
        }

        private void userBookSeacrhBtnChangePassword_Click(object sender, EventArgs e)
        {
            // hide current form and show next

            this.Hide();
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void UserBookSearchBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        public userBookSearch()
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
        private void usrBookSearchBtnIssuedBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            usrIssuedBooks uib = new usrIssuedBooks();
            uib.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserBookSearchTbxQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void admBookSearchBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }
    }
}
