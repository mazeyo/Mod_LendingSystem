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
    public partial class FrmUserAccount : Form
    {
        FrmUserChangePass userChangePass = new FrmUserChangePass();
        private string _userName = "qwerty";
        private string _fullName = "Dela Cruz, Juan";
        private string _maskedPassword = "**********";

        public FrmUserAccount()
        {
            InitializeComponent();
            this.Text = "User Account";

            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            lblNameUser.Text = _fullName;
            lblUsername.Text = _userName;
            lblPassword.Text = _maskedPassword;

            lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
        }

        private void FrmUserAccount_Load(object sender, EventArgs e)
        {
            // automatically load the user name from database
        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening the 'Change Password' form...",
                            "Edit Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            userChangePass.Show();
            this.Close();
        }
    }
}
