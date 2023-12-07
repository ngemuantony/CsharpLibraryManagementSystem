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
   
    public partial class login : Form
    {
        // variables
        SqlConnection con;
        SqlCommand cmd;

        // userid and pwd
        public static string username;
        public static string password;

        private void login_Load(object sender, EventArgs e)
        {
            // initialise connection to db
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            con = new SqlConnection(connectionString);
        }

        public login()
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
        // functions to empty text boxes on login
        public void clear()
        {
            loginTbxUserId.Text = string.Empty;
            loginTbxPassword.Text = string.Empty;
        }

        private void LoginBtnSubmit_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd = new SqlCommand("select * from Login where Username = @Username and UserPassword = @UserPassword", con);
            cmd.Parameters.AddWithValue("@Username", loginTbxUserId.Text);
            cmd.Parameters.AddWithValue("@UserPassword", loginTbxPassword.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                // successfully logged in, pass userid and pwd
                username = loginTbxUserId.Text;
                password = loginTbxPassword.Text;

                bool isAdmin = Convert.ToBoolean(dt.Rows[0]["IsAdmin"]);

                if (!isAdmin)
                {
                    this.Hide();
                    userBookSearch ubs = new userBookSearch();
                    ubs.Show();
                }
                else
                {
                    this.Hide();
                    // Assuming you want to show a different form for admins
                    admStartPage asp = new admStartPage();
                    asp.Show();
                }
            }
            else
            {
                MessageBox.Show("The entered USERNAME or PASSWORD is WRONG.\nPlease check and try again.\nIf you have forgotten the password then go to the system administrator to reset.");
                clear();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginTbxUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTbxPassword_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
