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
    public partial class FrmUserPay : Form
    {
        private decimal _currentBorrowedAmount = 7500.00m;
        private decimal _currentInterestAmount = 250.00m;
        private decimal _currentTotalBalance = 7750.00m;
        public FrmUserPay()
        {
            InitializeComponent();

            this.Text = "User Payment";

              LoadBalanceDetails();

            txtAmount.KeyPress += TxtAmount_KeyPress;
        }

        private void LoadBalanceDetails()
        {
            string currencyFormat = "N2";

            lblUBorrowedAmount.Text = _currentBorrowedAmount.ToString(currencyFormat);
            lblUInterestAmount.Text = _currentInterestAmount.ToString(currencyFormat);
            lblUTotalBal.Text = _currentTotalBalance.ToString(currencyFormat);
        }

        private void FrmUserPay_Load(object sender, EventArgs e)
        {
            // the labels in the form should be loaded automatically
            // the contents should be from the database and record of user
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpUserTransacDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPaySubmit_Click(object sender, EventArgs e)
        {
            string customerId = txtCustID.Text;
            string amountText = txtAmount.Text;
            DateTime transactionDate = dtpUserTransacDate.Value;


            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Please enter the Customer ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustID.Focus();
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amountToPay) || amountToPay <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }


            try
            {
                string message = $"Transaction Submitted!\n\n" +
                                 $"Customer ID: {customerId}\n" +
                                 $"Amount Paid: {amountToPay:C}\n" +
                                 $"Date: {transactionDate.ToShortDateString()}";

                MessageBox.Show(message, "Payment Submitted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCustID.Clear();
                txtAmount.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during submission: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Payment Submitted!");
            this.Close();
        }

        private void lblUBorrowedAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblUInterestAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblUTotalBal_Click(object sender, EventArgs e)
        {

        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    } 
}

