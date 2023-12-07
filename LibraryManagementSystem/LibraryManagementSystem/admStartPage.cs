using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{

    // this class functions as a redirecting hub
    public partial class admStartPage : Form
    {

        public admStartPage()
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
        private void admStartPage_Load(object sender, EventArgs e)
        {

        }

        private void admStartPageBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void admStartPageBtnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void admStartPageBtnBookSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            admBookSearchForm abs = new admBookSearchForm();
            abs.Show();
        }

        private void admStartPageBtnEditBookDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditBookDB aeb = new admEditBookDB();
            aeb.Show();
        }

        private void admStartPageBtnEditStudentDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditStudentDB aes = new admEditStudentDB();
            aes.Show();
        }

        private void admStartPageBtnIssue_Click(object sender, EventArgs e)
        {
            this.Hide();
            admIssue ai = new admIssue();
            ai.Show();
        }

        private void admStartPageBtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            admReturn ar = new admReturn();
            ar.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iSSUEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admBookSearchForm abs = new admBookSearchForm();
            abs.Show();
        }

        private void mANAGEACCOUNTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void admStartPageBtnBookSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void iSSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admIssue ai = new admIssue();
            ai.Show();
        }

        private void eDITBOOKDATABASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditBookDB aeb = new admEditBookDB();
            aeb.Show();
        }

        private void rETURNBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admReturn ar = new admReturn();
            ar.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admEditStudentDB aes = new admEditStudentDB();
            aes.Show();
        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usrIssuedBooks ub = new usrIssuedBooks();
            ub.Show();
        }

        private void mANAGEMEMBERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryMembers lm = new LibraryMembers();
            lm.Show();
        }

        private void admIssueBooksBtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
