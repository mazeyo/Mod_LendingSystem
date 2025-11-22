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
    public partial class FrmPay : Form
    {
        private decimal _currentBorrowedAmount = 0.00m;
        private decimal _currentInterestAmount = 0.00m;
        private decimal _currentTotalBalance = 0.00m;
        public FrmPay()
        {
            InitializeComponent();

            this.Text = "Pay Transaction";

            // Set initial state for display labels
            UpdateDisplayLabels();

            // Ensure the Amount to Pay textbox is focused on numbers
            lblBorrowedAmount.KeyPress += TxtAmountToPay_KeyPress;
        }

        private void UpdateDisplayLabels()
        {
            // Use CultureInfo.GetCultureInfo("en-US") or your local currency culture
            string currencyFormat = "N2";

            lblBorrowedAmount.Text = _currentBorrowedAmount.ToString(currencyFormat);
            lblInterestAmount.Text = _currentInterestAmount.ToString(currencyFormat);
            lblTotalBal.Text = _currentTotalBalance.ToString(currencyFormat);
        }

        private void FrmPay_Load(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_currentTotalBalance <= 0)
            {
                MessageBox.Show("There is no outstanding balance to pay.", "No Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFirstname.Text, out decimal amountToPay) || amountToPay <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstname.Focus();
                return;
            }

            try
            {
                string customerId = txtCustID.Text;
                DateTime transactionDate = dateTimePicker1.Value;

                if (amountToPay > _currentTotalBalance)
                {
                    decimal change = amountToPay - _currentTotalBalance;
                    MessageBox.Show($"Payment successful! Change returned: {change:C}. Account fully cleared.",
                                   "Payment Complete",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                    _currentBorrowedAmount = 0.00m;
                    _currentInterestAmount = 0.00m;
                    _currentTotalBalance = 0.00m;
                }
                else
                {
                    _currentTotalBalance -= amountToPay;

                    MessageBox.Show($"Payment of {amountToPay:C} processed on {transactionDate.ToShortDateString()}. Remaining balance: {_currentTotalBalance:C}",
                                    "Payment Partial",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                UpdateDisplayLabels();
                txtFirstname.Clear(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during payment: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtAmountToPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerId = txtCustID.Text;

            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Please enter the Customer ID first.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (customerId == "1001")
                {
                    _currentBorrowedAmount = 5000.00m;
                    _currentInterestAmount = 50.00m;
                    _currentTotalBalance = _currentBorrowedAmount + _currentInterestAmount;

                    MessageBox.Show($"Customer {customerId} bill details loaded.", "Data Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _currentBorrowedAmount = 0.00m;
                    _currentInterestAmount = 0.00m;
                    _currentTotalBalance = 0.00m;
                    MessageBox.Show("Customer ID not found or account cleared.", "No Bill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateDisplayLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching bill details: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void FrmPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void lblTotalBal_Click(object sender, EventArgs e)
        {

        }
    }
}

