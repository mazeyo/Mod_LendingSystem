namespace Mod_LendingSystem
{
    partial class FrmTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridviewTransaction = new DataGridView();
            Cust_Id = new DataGridViewTextBoxColumn();
            Fname = new DataGridViewTextBoxColumn();
            Lname = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            contactNum = new DataGridViewTextBoxColumn();
            TransacDate = new DataGridViewTextBoxColumn();
            Duedate = new DataGridViewTextBoxColumn();
            PaymentSched = new DataGridViewTextBoxColumn();
            IntRate = new DataGridViewTextBoxColumn();
            IntBal = new DataGridViewTextBoxColumn();
            TotalBal = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLend = new Button();
            btnPay = new Button();
            menuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridviewTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // gridviewTransaction
            // 
            gridviewTransaction.AllowUserToDeleteRows = false;
            gridviewTransaction.BackgroundColor = Color.FromArgb(118, 132, 85);
            gridviewTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewTransaction.Columns.AddRange(new DataGridViewColumn[] { Cust_Id, Fname, Lname, MiddleName, contactNum, TransacDate, Duedate, PaymentSched, IntRate, IntBal, TotalBal });
            gridviewTransaction.Location = new Point(5, 107);
            gridviewTransaction.Margin = new Padding(3, 2, 3, 2);
            gridviewTransaction.Name = "gridviewTransaction";
            gridviewTransaction.ReadOnly = true;
            gridviewTransaction.RowHeadersWidth = 51;
            gridviewTransaction.Size = new Size(1133, 328);
            gridviewTransaction.TabIndex = 0;
            gridviewTransaction.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Cust_Id
            // 
            Cust_Id.HeaderText = "Customer ID";
            Cust_Id.MinimumWidth = 6;
            Cust_Id.Name = "Cust_Id";
            Cust_Id.ReadOnly = true;
            Cust_Id.Width = 125;
            // 
            // Fname
            // 
            Fname.HeaderText = "First Name";
            Fname.MinimumWidth = 6;
            Fname.Name = "Fname";
            Fname.ReadOnly = true;
            Fname.Width = 125;
            // 
            // Lname
            // 
            Lname.HeaderText = "Last Name";
            Lname.MinimumWidth = 6;
            Lname.Name = "Lname";
            Lname.ReadOnly = true;
            Lname.Width = 125;
            // 
            // MiddleName
            // 
            MiddleName.HeaderText = "Middle Initial";
            MiddleName.MinimumWidth = 6;
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            MiddleName.Width = 125;
            // 
            // contactNum
            // 
            contactNum.HeaderText = "Contact No.";
            contactNum.MinimumWidth = 6;
            contactNum.Name = "contactNum";
            contactNum.ReadOnly = true;
            contactNum.Width = 125;
            // 
            // TransacDate
            // 
            TransacDate.HeaderText = "Date of Transaction";
            TransacDate.MinimumWidth = 6;
            TransacDate.Name = "TransacDate";
            TransacDate.ReadOnly = true;
            TransacDate.Width = 125;
            // 
            // Duedate
            // 
            Duedate.HeaderText = "Due Date";
            Duedate.MinimumWidth = 6;
            Duedate.Name = "Duedate";
            Duedate.ReadOnly = true;
            Duedate.Width = 125;
            // 
            // PaymentSched
            // 
            PaymentSched.HeaderText = "Payment Schedule";
            PaymentSched.MinimumWidth = 6;
            PaymentSched.Name = "PaymentSched";
            PaymentSched.ReadOnly = true;
            PaymentSched.Width = 125;
            // 
            // IntRate
            // 
            IntRate.HeaderText = "Interest Rate (%)";
            IntRate.MinimumWidth = 6;
            IntRate.Name = "IntRate";
            IntRate.ReadOnly = true;
            IntRate.Width = 125;
            // 
            // IntBal
            // 
            IntBal.HeaderText = "Initial Balance";
            IntBal.MinimumWidth = 6;
            IntBal.Name = "IntBal";
            IntBal.ReadOnly = true;
            IntBal.Width = 125;
            // 
            // TotalBal
            // 
            TotalBal.HeaderText = "Total Balance";
            TotalBal.MinimumWidth = 6;
            TotalBal.Name = "TotalBal";
            TotalBal.ReadOnly = true;
            TotalBal.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.money_cash_svgrepo_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(8, 5);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 98);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(124, 35);
            label1.Name = "label1";
            label1.Size = new Size(337, 41);
            label1.TabIndex = 2;
            label1.Text = "Money Lending System";
            // 
            // btnLend
            // 
            btnLend.BackColor = Color.FromArgb(128, 194, 48);
            btnLend.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnLend.FlatAppearance.BorderSize = 2;
            btnLend.FlatStyle = FlatStyle.Popup;
            btnLend.Font = new Font("Segoe UI", 18F);
            btnLend.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnLend.Location = new Point(716, 34);
            btnLend.Margin = new Padding(3, 2, 3, 2);
            btnLend.Name = "btnLend";
            btnLend.Size = new Size(151, 44);
            btnLend.TabIndex = 3;
            btnLend.Text = "Lend";
            btnLend.UseVisualStyleBackColor = false;
            btnLend.Click += btnLend_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(128, 194, 48);
            btnPay.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnPay.FlatAppearance.BorderSize = 2;
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.Font = new Font("Segoe UI", 18F);
            btnPay.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnPay.Location = new Point(903, 34);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(151, 44);
            btnPay.TabIndex = 4;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Transparent;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.RightToLeft = RightToLeft.Yes;
            menuStrip.Size = new Size(1143, 24);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountToolStripMenuItem, historyToolStripMenuItem, signOutToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(120, 22);
            accountToolStripMenuItem.Text = "Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(94, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(120, 22);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(120, 22);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // FrmTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(1143, 433);
            Controls.Add(btnPay);
            Controls.Add(btnLend);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(gridviewTransaction);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmTransactions";
            Text = "Transactions";
            FormClosing += FrmTransactions_FormClosing;
            Load += FrmTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)gridviewTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridviewTransaction;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnLend;
        private Button btnPay;
        private DataGridViewTextBoxColumn Cust_Id;
        private DataGridViewTextBoxColumn Fname;
        private DataGridViewTextBoxColumn Lname;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn contactNum;
        private DataGridViewTextBoxColumn TransacDate;
        private DataGridViewTextBoxColumn Duedate;
        private DataGridViewTextBoxColumn PaymentSched;
        private DataGridViewTextBoxColumn IntRate;
        private DataGridViewTextBoxColumn IntBal;
        private DataGridViewTextBoxColumn TotalBal;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}