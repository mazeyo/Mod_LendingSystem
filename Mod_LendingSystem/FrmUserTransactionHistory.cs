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
    public partial class FrmUserTransactionHistory : Form
    {
        FrmUserTransaction userHomePage = new FrmUserTransaction();
        public FrmUserTransactionHistory()
        {
            InitializeComponent();
        }

        private void FrmUserTransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void dgvUserTransacHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            userHomePage.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
