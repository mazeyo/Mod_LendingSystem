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
    public partial class FrmTransactionHistory : Form
    {
        private DataTable _fullHistoryData;

        public FrmTransactionHistory()
        {
            InitializeComponent();
            this.Text = "Transaction History";

            InitializeHistoryGrid();
        }

        private void InitializeHistoryGrid()
        {
            _fullHistoryData = new DataTable();

            _fullHistoryData.Columns.Add("Customer ID", typeof(int));
            _fullHistoryData.Columns.Add("First Name", typeof(string));
            _fullHistoryData.Columns.Add("Last Name", typeof(string));
            _fullHistoryData.Columns.Add("Middle Initial", typeof(string));
            _fullHistoryData.Columns.Add("Contact No.", typeof(string));
            _fullHistoryData.Columns.Add("Date of Transaction", typeof(DateTime));
            _fullHistoryData.Columns.Add("Due Date", typeof(DateTime));
            _fullHistoryData.Columns.Add("Payment Schedule", typeof(string));
            _fullHistoryData.Columns.Add("Interest Rate", typeof(decimal));
            _fullHistoryData.Columns.Add("Status", typeof(string)); 

            _fullHistoryData.Rows.Add(1001, "Juan", "Dela Cruz", "M", "0917-555-1234", DateTime.Today.AddDays(-60), DateTime.Today.AddDays(-30), "Monthly", 0.05m, "Paid");
            _fullHistoryData.Rows.Add(1004, "Lisa", "Manalo", "K", "0918-123-4567", DateTime.Today.AddYears(-1), DateTime.Today.AddMonths(-11), "Quarterly", 0.06m, "Default");
            _fullHistoryData.Rows.Add(1005, "Ben", "Sy", "C", "0999-000-1111", DateTime.Today.AddMonths(-3), DateTime.Today.AddMonths(-1), "Bi-Weekly", 0.03m, "Paid");
            _fullHistoryData.Rows.Add(1001, "Juan", "Dela Cruz", "M", "0917-555-1234", DateTime.Today.AddDays(-30), DateTime.Today.AddDays(15), "Monthly", 0.05m, "Active");

            gridviewHistoryTransaction.DataSource = _fullHistoryData;

            gridviewHistoryTransaction.AllowUserToAddRows = false;
            gridviewHistoryTransaction.ReadOnly = true;
            gridviewHistoryTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmTransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void gridviewHistoryTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ApplyFilter();
                e.Handled = true; 
            }
        }

        private void ApplyFilter()
        {
            string searchText = txtSearchBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                 gridviewHistoryTransaction.DataSource = _fullHistoryData;
            }
            else
            {
                var filteredRows = _fullHistoryData.AsEnumerable()
                    .Where(row => row.Field<int>("Customer ID").ToString().Contains(searchText) ||
                                  row.Field<string>("First Name").ToLower().Contains(searchText.ToLower()) ||
                                  row.Field<string>("Last Name").ToLower().Contains(searchText.ToLower()) ||
                                  row.Field<string>("Status").ToLower().Contains(searchText.ToLower()));

                if (filteredRows.Any())
                {
                    gridviewHistoryTransaction.DataSource = filteredRows.CopyToDataTable();
                }
                else
                {
                    gridviewHistoryTransaction.DataSource = null;
                    MessageBox.Show("No matching transactions found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmTransactionHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
