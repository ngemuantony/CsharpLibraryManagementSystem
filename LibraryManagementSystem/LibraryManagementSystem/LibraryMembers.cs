using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibraryMembers : Form
    {
        private readonly string connectionString;

        public LibraryMembers()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LibraryDB"].ToString();
            DisplayBorrowers();
            dgvBorrowers.CellClick += DgvBorrowers_CellClick; // Add CellClick event handler
            //MINIMIZING FUNCTIONALITY

            ControlBox = false; // Disable the control box (including the form icon and system menu)
            FormClosing += LibraryMembers_FormClosing;
        }

        private void DgvBorrowers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click to populate textboxes
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBorrowers.Rows[e.RowIndex];

                // Example: Populate textboxes with data from selected row
                txtBorrowerID.Text = selectedRow.Cells["BorrowerID"].Value.ToString();
                txtFullName.Text = selectedRow.Cells["FullName"].Value.ToString();
                txtUserAddress.Text = selectedRow.Cells["UserAddress"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }
        // MINIMIZING FUNCTIONALITY




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


        private void DisplayBorrowers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Borrower", con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                dgvBorrowers.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Borrower (BorrowerID, FullName, UserAddress, Phone, Email) " +
                                                           "VALUES (@BorrowerID, @FullName, @UserAddress, @Phone, @Email)", con))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerID", int.Parse(txtBorrowerID.Text));
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@UserAddress", txtUserAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Borrower added successfully.");
                        DisplayBorrowers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Borrower SET FullName = @FullName, UserAddress = @UserAddress, " +
                                                           "Phone = @Phone, Email = @Email WHERE BorrowerID = @BorrowerID", con))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerID", int.Parse(txtBorrowerID.Text));
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@UserAddress", txtUserAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Borrower updated successfully.");
                        DisplayBorrowers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LibraryMembers_Load(object sender, EventArgs e)
        {
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Borrower WHERE BorrowerID = @BorrowerID", con))
                    {
                        cmd.Parameters.AddWithValue("@BorrowerID", int.Parse(txtBorrowerID.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Borrower deleted successfully.");
                        DisplayBorrowers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            admStartPage asp = new admStartPage();
            asp.Show();
        }

        private void dgvBorrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Existing code...
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Borrower WHERE FullName LIKE @SearchTerm", con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtSearch.Text + "%");

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                sda.Fill(ds);
                                dgvBorrowers.DataSource = ds.Tables[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
