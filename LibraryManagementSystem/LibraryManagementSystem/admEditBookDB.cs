using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class admEditBookDB : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        // selected book id
        int selected_book_id;

        private void admEditBookDB_Load(object sender, EventArgs e)
        {

            // display table
            displayBooks();

            // select both radio button by default
            admEditBookDBRbBoth.Select();
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
        // display the table of books
        public void displayBooks()
        {
            // establish connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);

            // on intialise display books table
            cmd = new SqlCommand("select BookID as 'Book ID', Title as 'Title', Author as 'Author', Publisher as 'Publisher', YearOfPublication as 'Year of Publication', Genres as 'Genres' from Books order by BookID asc", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            editBookDBDgvTable.DataSource = ds.Tables[0];

            // make read only
            editBookDBDgvTable.ReadOnly = true;
        }

        // clear the value of the fields
        public void clearFields()
        {
            editBookDBTbxBookID.Text = string.Empty;
            editBookDBTbxTitle.Text = string.Empty;
            editBookDBTbxAuthor.Text = string.Empty;
            editBookDBTbxPublisher.Text = string.Empty;
            editBookDBTbxYop.Text = string.Empty;
            editBookDBTbxGenres.Text = string.Empty;
        }

        public admEditBookDB()
        {
            InitializeComponent();
            ControlBox = false; // Disable the control box (including the form icon and system menu)
            FormClosing += LibraryMembers_FormClosing;
        }

        private void admEditBookDBBtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void admEditBookDBBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        // search the book DB functionality
        private void editBookDBBtnSearch_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (admEditBookDBRbBoth.Checked == true)
            {
                cmd = new SqlCommand("select * from Books where Title like @searchQuery or Author like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                editBookDBDgvTable.DataSource = ds.Tables[0];
            }
            else if (admEditBookDBRbTitle.Checked == true)
            {
                cmd = new SqlCommand("select * from Books where Title like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                editBookDBDgvTable.DataSource = ds.Tables[0];
            }
            else if (admEditBookDBRbAuthor.Checked == true)
            {
                cmd = new SqlCommand("select * from Books where Author like @searchQuery", con);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + editBookDBTbxSearch.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                editBookDBDgvTable.DataSource = ds.Tables[0];
            }
        }

        private void admEditBookDBBtnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Clicking cell of datagridview
        private void editBookDBDgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // remove column headers
            if(e.RowIndex != -1 && e.RowIndex != editBookDBDgvTable.Rows.Count - 1)
            {
                // copy value to variable even if unnecessary
                selected_book_id = Convert.ToInt32(editBookDBDgvTable.Rows[e.RowIndex].Cells[0].Value);
                string title = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[1].Value);
                string author = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[2].Value);
                string publisher = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[3].Value);
                int year_of_pub = Convert.ToInt32(editBookDBDgvTable.Rows[e.RowIndex].Cells[4].Value);
                string genres = Convert.ToString(editBookDBDgvTable.Rows[e.RowIndex].Cells[5].Value);

                // paste into textbox
                editBookDBTbxBookID.Text = Convert.ToString(selected_book_id);
                editBookDBTbxTitle.Text = title;
                editBookDBTbxAuthor.Text = author;
                editBookDBTbxPublisher.Text = publisher;
                editBookDBTbxYop.Text = Convert.ToString(year_of_pub);
                editBookDBTbxGenres.Text = genres;
            }
        }

        // SAVE EDIT BUTTON
        private void editBookDBBtnSave_Click(object sender, EventArgs e)
        {
            // variables 
            int book_id = 0;
            string title;
            string author;
            string publisher;
            int year_of_pub = 0000;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                 book_id = Convert.ToInt32(editBookDBTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the BookID is an interger.");
                preliminaryAcceptedState = false;
            }
            title = editBookDBTbxTitle.Text;
            author = editBookDBTbxAuthor.Text;
            publisher = editBookDBTbxPublisher.Text;
            try
            {
                year_of_pub = Convert.ToInt32(editBookDBTbxYop.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Year of Publication is an interger.");
                preliminaryAcceptedState = false;
            }
            string genres = editBookDBTbxGenres.Text;
            
            // try to edit book only if all pevious info is healthy
            if(preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("update books set BookID = @book_id, Title = @title, Author = @author, Publisher = @publisher, YearOfPublication = @year_of_pub, Genres = @genres where BookID = @selected_book_id", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@year_of_pub", year_of_pub);
                    cmd.Parameters.AddWithValue("@genres", genres);
                    cmd.Parameters.AddWithValue("@selected_book_id", selected_book_id);

                    int result = cmd.ExecuteNonQuery();
                    if(result == 1)
                    {
                        MessageBox.Show("Changes successfully saved.");
                        clearFields();
                    }

                    // display updated books
                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("There is already a book with this BookID.\nBookID's have to be distinct.");
                }
            }
        }

        // ADD TO DB BUTTON
        private void editBookDBBtnAddToDB_Click(object sender, EventArgs e)
        {
            // variables 
            int book_id = 0;
            string title;
            string author;
            string publisher;
            int year_of_pub = 0000;
            string genres;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                book_id = Convert.ToInt32(editBookDBTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the BookID is an interger.");
                preliminaryAcceptedState = false;
            }
            title = editBookDBTbxTitle.Text;
            author = editBookDBTbxAuthor.Text;
            publisher = editBookDBTbxPublisher.Text;
            try
            {
                year_of_pub = Convert.ToInt32(editBookDBTbxYop.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the Year of Publication is an interger.");
                preliminaryAcceptedState = false;
            }
            genres = editBookDBTbxGenres.Text;

            // try to add book only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("insert into Books values (@book_id, @title, @author, @publisher, @year_of_pub, @genres)", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@year_of_pub", year_of_pub);
                    cmd.Parameters.AddWithValue("@genres", genres);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully added.");
                        clearFields();
                    }

                    // display updated books
                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("There is already a book with this BookID.\nBookID's have to be distinct.");
                }
            }
        }

        // DELETE BUTTON
        private void editBookDBBtnDelete_Click(object sender, EventArgs e)
        {
            // variables 
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            // open connection
            if (con.State == ConnectionState.Closed)
                con.Open();

            // copy values
            // copy value to variable even make sure correct format
            try
            {
                book_id = Convert.ToInt32(editBookDBTbxBookID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure that the BookID is an interger.");
                preliminaryAcceptedState = false;
            }

            // try to edit book only if all pevious info is healthy
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("delete from Books where BookID = @book_id", con);
                    cmd.Parameters.AddWithValue("@book_id", book_id);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully deleted.");
                        clearFields();
                    }

                    // display updated books
                    displayBooks();
                }
                catch
                {
                    MessageBox.Show("Cannot delete an issued book.\nPlease make sure the book is not issued to a student before deleting it.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
