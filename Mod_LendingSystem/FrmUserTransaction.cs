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
    public partial class FrmUserTransaction : Form
    {
        FrmUserLend userLend = new FrmUserLend();
        FrmUserPay userPay = new FrmUserPay();
        FrmUserChangePass userChangePass = new FrmUserChangePass();
        FrmUserAccount userAccount = new FrmUserAccount();  
        FrmTransactionHistory transactionHistory = new FrmTransactionHistory();


        public FrmUserTransaction()
        {
            InitializeComponent();
        }

        private void lblCurrentBal_Click(object sender, EventArgs e)
        {
            // should reflect the user's balance from the database 
            // and is found also in the admin transaction table
        }

        private void lblDuedatePayment_Click(object sender, EventArgs e)
        {
            // date must also reflect the user's due date from the database
            // that is in the admin transaction table
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            userLend.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            userPay.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void FrmUserTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been signed out.");
            this.Hide();
            FrmLogIn loginform = new FrmLogIn();
            loginform.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add breakdown of user transaction history form show dialog here
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionHistory.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userAccount.Show();
            this.Hide();
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userChangePass.Show();
            this.Hide();
        }
    }
}
