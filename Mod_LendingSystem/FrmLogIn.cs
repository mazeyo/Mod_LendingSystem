using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod_LendingSystem
{
    public partial class FrmLogIn : Form
    {
        FrmRegistration reg = new FrmRegistration();
        FrmTransactions transac = new FrmTransactions();
        FrmUserTransaction usertransaction = new FrmUserTransaction();


        public FrmLogIn()
        {
            InitializeComponent();
            this.Text = "Log In";
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogIn_Load_1(object sender, EventArgs e)
        {

        }

        private void txtUnameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassLogIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUnameLogin.Text;
            string password = txtPassLogIn.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both a username and a password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            const string ValidUsername = "user";
            const string ValidPassword = "password123";

            if (username.Equals(ValidUsername, StringComparison.OrdinalIgnoreCase) && password.Equals(ValidPassword))
            {
                MessageBox.Show("Login successful! Welcome.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPassLogIn.Clear();
                txtUnameLogin.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txtUnameLogin.Text = string.Empty;
            txtPassLogIn.Text = string.Empty;
        }

        private void linkLabelSignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            reg.Show();
            this.Hide();
        }

        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
