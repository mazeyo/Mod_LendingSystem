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
    public partial class FrmUserLend : Form
    {
        public FrmUserLend()
        {
            InitializeComponent();
        }

        private void FrmUserLend_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void FrmUserLend_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUserPaymentSched_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUserContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpUserTransacDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLendSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Submitted!");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
