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
    public partial class FrmTransactions : Form
    {
        FrmLend lendform = new FrmLend();
        FrmPay payform = new FrmPay();
        public FrmTransactions()
        {
            InitializeComponent();

            this.Text = "Transactions - Money Lending System";

            InitializeTransactionGrid();

        }

        private void InitializeTransactionGrid()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Customer ID", typeof(int));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Middle Initial", typeof(string));
            dt.Columns.Add("Contact No.", typeof(string));
            dt.Columns.Add("Date of Transaction", typeof(DateTime));
            dt.Columns.Add("Due Date", typeof(DateTime));
            dt.Columns.Add("Payment Schedule", typeof(string));
            dt.Columns.Add("Interest Rate", typeof(decimal));

            dt.Rows.Add(1001, "Juan", "Dela Cruz", "M", "0917-555-1234", DateTime.Today.AddDays(-30), DateTime.Today.AddDays(15), "Monthly", 0.05m);
            dt.Rows.Add(1002, "Maria", "Santos", "A", "0920-111-5678", DateTime.Today.AddDays(-10), DateTime.Today.AddDays(20), "Weekly", 0.03m);
            dt.Rows.Add(1003, "Ramon", "Gomez", "L", "0998-999-0000", DateTime.Today.AddDays(-50), DateTime.Today.AddDays(10), "Bi-Weekly", 0.04m);

            gridviewTransaction.DataSource = dt;

            gridviewTransaction.AllowUserToAddRows = false;
            gridviewTransaction.ReadOnly = true;
            gridviewTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void FrmTransactions_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            lendform.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening the 'Payment Transaction' form...",
                            "Payment",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying application menu options...",
                            "Menu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            payform.Show();
        }

        private void FrmTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSignOut_Click(object sender, EventArgs e)
        {
            FrmLogIn loginform = new FrmLogIn();
            loginform.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccount acc = new FrmAccount();
            acc.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransactionHistory history = new FrmTransactionHistory();
            history.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been signed out.");
            this.Hide();
            FrmLogIn loginform = new FrmLogIn();
            loginform.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword changepass = new FrmChangePassword();
            changepass.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
