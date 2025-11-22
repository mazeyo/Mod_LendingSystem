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
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void lblNameUser_Click(object sender, EventArgs e)
        {
            // from the sign in, the namme should be reflected here
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmChangePassword changepass = new FrmChangePassword();
            changepass.Show();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
