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
    public partial class FrmUserChangePass : Form
    {
        FrmUserAccount userAccount = new FrmUserAccount();
        public FrmUserChangePass()
        {
            InitializeComponent();
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

        private void btnUserChangePass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Changed!");
            userAccount.Show();
            this.Close();
        }
    }
}
