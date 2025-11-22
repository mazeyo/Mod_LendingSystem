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
    public partial class FrmLend : Form
    {
        private object tempLoan;

        public FrmLend()
        {
            InitializeComponent();
        }

        private void FrmLend_Load(object sender, EventArgs e)
        {
            LoadInitialData();
            dtpTransacDate.Value = DateTime.Now.Date;
            CalculateAndSetDueDate();
        }

        private void LoadInitialData()
        {
            cbInterestRate.Items.Add("3.0");
            cbInterestRate.Items.Add("5.0");
            cbInterestRate.Items.Add("7.5");
            cbInterestRate.SelectedIndex = 1;

            cbPaymentSched.Items.Add("Monthly");
            cbPaymentSched.Items.Add("Quarterly");
            cbPaymentSched.Items.Add("Yearly");
            cbPaymentSched.SelectedIndex = 0; 
        }

        private void CalculateAndSetDueDate()
        {
            if (dtpTransacDate.Value == DateTime.MinValue || cbPaymentSched.SelectedItem == null)
            {
                return;
            }

            LoanTransaction newLoan = new LoanTransaction
            {
                TransactionDate = dtpTransacDate.Value.Date,
                PaymentSchedule = cbPaymentSched.SelectedItem.ToString()
            };

            tempLoan.CalculateDueDate();

            if (tempLoan.DueDate != DateTime.MinValue)
            {
                dtpDueDate.Value = tempLoan.DueDate;
            }
        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbInterestRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPaymentSched_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAndSetDueDate();
        }

        private void dtpTransacDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndSetDueDate();
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustID.Text) || string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                MessageBox.Show("Customer ID and First Name are required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive loan amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(cbInterestRate.SelectedItem?.ToString(), out double interestRate) || interestRate < 0)
            {
                MessageBox.Show("Please select a valid interest rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string paymentSchedule = cbPaymentSched.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(paymentSchedule))
            {
                MessageBox.Show("Please select a payment schedule.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            char? middleInitial = null;
            if (!string.IsNullOrWhiteSpace(txtMI.Text))
            {
                middleInitial = txtMI.Text.Trim().ToUpper()[0];
            }

            LoanTransaction newLoan = new LoanTransaction
            {
                txtCustID = Text.Trim(),
                FirstName = txtFirstname.Text.Trim(),
                LastName = txtLastname.Text.Trim(),
                MiddleInitial = middleInitial,
                ContactNo = txtContactNo.Text.Trim(),

                Amount = amount,
                InterestRatePercent = interestRate,
                PaymentSchedule = paymentSchedule,
                TransactionDate = dtpTransacDate.Value.Date,
            };

            newLoan.FinalizeTransaction();

            dtpDueDate.Value = newLoan.DueDate;

            string confirmationMessage = $@"
            Loan Summary:
            ------------------------------------------
            Customer: {newLoan.FirstName} {newLoan.MiddleInitial}. {newLoan.LastName}
            Loan Amount: {newLoan.Amount:C2}
            Interest Rate: {newLoan.InterestRatePercent}%
            Interest Due: {newLoan.InterestAmount:C2}
            ------------------------------------------
            TOTAL DUE: {newLoan.TotalDue:C2}

            Payment Schedule: {newLoan.PaymentSchedule}
            Due Date: {newLoan.DueDate.ToShortDateString()}

            Do you want to finalize this lending transaction?";

            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Loan Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        

        private void FrmLend_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
