using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Mod_LendingSystem
{
    public partial class FrmRegistration : Form
    {

        private string fullName, userName, password, confirmPass;

        
        public FrmRegistration()
        {
            InitializeComponent();
            this.Text = "Registration";

            txtPassword.UseSystemPasswordChar = true;
            txtPassConfirmation.UseSystemPasswordChar = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("Directing you to the Login page.", 
                            "Login", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
            
            this.Close(); 
        }

        
        private bool CheckUsernameExists(string username)
        {
            return username.ToLower() == "admin";
        }
        
        private void ClearForm()
        {
            txtFname.Clear();
            txtLName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassConfirmation.Clear();
            txtFname.Focus();
        
            ClearFields();
            FrmLogIn frmlogIn = new FrmLogIn();
            frmlogIn.Show();
            this.Close();

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassConfirmation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtLName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtPassConfirmation.Text))
            {
                MessageBox.Show("Please enter all required fields.", "Incomplete Form",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserInfoClass.SetFullName = FullName(txtFname.Text, txtLName.Text);
                UserInfoClass.SetUsername = Username(txtUsername.Text);
                UserInfoClass.SetPassword = Password(txtPassword.Text);
                UserInfoClass.SetPassConfirm = ConfirmPassword(txtPassConfirmation.Text);

                if (confirmPass != password)
                {
                    MessageBox.Show("Password does not match!");
                }
                else
                {
                    MessageBox.Show("Registered successfully! Welcome " + userName);
                }

                ClearFields();
                FrmLogIn frmlogIn = new FrmLogIn();
                frmlogIn.Show();
                this.Hide();

            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("Argument Null Exception: " + ane.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Format Exception: " + fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Overflow Exception: " + oe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index Out Of Range Exception: " + ioore.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Registration attempt finished.");
            }

            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public string FullName(string LastName, string FirstName)
        {
            if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName))
            {
                throw new ArgumentNullException("Last Name, and First Name Initial fields must not be empty.");
            }

            if (!Regex.IsMatch(LastName, @"^[a-zA-Z\s.-]+$") || !Regex.IsMatch(FirstName, @"^[a-zA-Z\s.-]+$"))
            {
                throw new FormatException("Names must only contain letters, spaces, periods, or hyphens.");
            }

            fullName = FirstName + LastName;
            return fullName;
        }

        public string Username(string UserName)
        {
            if (string.IsNullOrEmpty(UserName))
            {
                throw new ArgumentNullException("Username must not be empty.");
            }
            if (!Regex.IsMatch(UserName, @"^[a-zA-Z0-9_]+$"))
            {
                throw new FormatException("Username must only contains letters, underscore, and numbers.");
            }
            userName = UserName;
            return userName;
        }

        public string Password(string Pass)
        {
            if (string.IsNullOrEmpty(Pass))
            {
                throw new ArgumentNullException("Password must not be empty.");
            }
            if (!Regex.IsMatch(Pass, @"^[a-zA-Z0-9]+$"))
            {
                throw new FormatException("Password must only contains letters, and numbers.");
            }
            password = Pass;
            return password;
        }

        public string ConfirmPassword(string ConfirmPass)
        {
            if (string.IsNullOrEmpty(ConfirmPass))
            {
                throw new ArgumentNullException("Confirm Password must not be empty.");
            }
            if (!Regex.IsMatch(ConfirmPass, @"^[a-zA-Z0-9]+$"))
            {
                throw new FormatException("Confirm Password must only contains letters, and numbers.");
            }
            confirmPass = ConfirmPass;
            return password;
        }

        private void ClearFields()
        {
            txtFname.Clear();
            txtLName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPassConfirmation.Clear();
        }

        public class PasswordConfirmException : Exception
        {
            public PasswordConfirmException(string str) : base(str)
            {

            }
        }

        private void FrmRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLogIn frmLogin = new FrmLogIn();
            frmLogin.Close();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }


    public static class UserInfoClass
    {
        public static string SetFullName { get; set;  }
        public static string SetUsername { get; set; }
        public static string SetPassword { get; set; }
        public static string SetPassConfirm { get; set; }



    }
}
