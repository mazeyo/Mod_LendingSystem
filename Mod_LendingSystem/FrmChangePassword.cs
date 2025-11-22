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
    public partial class FrmChangePassword : Form
    {
        private string _currentPassword = "securePassword123";
        public FrmChangePassword()
        {
            InitializeComponent();
            this.Text = "Change Password";

            txtOldPass.UseSystemPasswordChar = true;
            txtNewPass.UseSystemPasswordChar = true;
            txtConfrimNewPass.UseSystemPasswordChar = true;
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfrimNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPass.Text;
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConfrimNewPass.Text;

            if (string.IsNullOrWhiteSpace(oldPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields must be filled out.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (oldPassword != _currentPassword)
            {
                MessageBox.Show("The old password you entered is incorrect.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtOldPass.Clear();
                txtOldPass.Focus();
                return;
            }

            if (newPassword == oldPassword)
            {
                MessageBox.Show("The new password cannot be the same as the old password.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNewPass.Clear();
                txtConfrimNewPass.Clear();
                txtNewPass.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtConfrimNewPass.Clear();
                txtConfrimNewPass.Focus();
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.",
                               "Validation Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                txtNewPass.Clear();
                txtConfrimNewPass.Clear();
                txtNewPass.Focus();
                return;
            }


            _currentPassword = newPassword;

            MessageBox.Show("Password successfully changed!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            txtOldPass.Clear();
            txtNewPass.Clear();
            txtConfrimNewPass.Clear();

        
        }

        private void FrmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
