namespace Mod_LendingSystem
{
    partial class FrmTransactionHistory
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
            gridviewHistoryTransaction = new DataGridView();
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
            label1 = new Label();
            txtSearchBox = new TextBox();
            btnSearch = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridviewHistoryTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridviewHistoryTransaction
            // 
            gridviewHistoryTransaction.AllowUserToDeleteRows = false;
            gridviewHistoryTransaction.BackgroundColor = Color.FromArgb(118, 132, 85);
            gridviewHistoryTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewHistoryTransaction.Columns.AddRange(new DataGridViewColumn[] { Cust_Id, Fname, Lname, MiddleName, contactNum, TransacDate, Duedate, PaymentSched, IntRate, IntBal, TotalBal });
            gridviewHistoryTransaction.Location = new Point(6, 92);
            gridviewHistoryTransaction.Name = "gridviewHistoryTransaction";
            gridviewHistoryTransaction.ReadOnly = true;
            gridviewHistoryTransaction.RowHeadersWidth = 51;
            gridviewHistoryTransaction.Size = new Size(1295, 487);
            gridviewHistoryTransaction.TabIndex = 1;
            gridviewHistoryTransaction.CellContentClick += gridviewHistoryTransaction_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(103, 20);
            label1.Name = "label1";
            label1.Size = new Size(144, 50);
            label1.TabIndex = 3;
            label1.Text = "History";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Font = new Font("Segoe UI", 12F);
            txtSearchBox.Location = new Point(959, 34);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(253, 34);
            txtSearchBox.TabIndex = 4;
            txtSearchBox.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = Properties.Resources.Search;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 18F);
            btnSearch.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnSearch.Location = new Point(1218, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(47, 45);
            btnSearch.TabIndex = 16;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.History;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 80);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // FrmTransactionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(1306, 577);
            Controls.Add(pictureBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBox);
            Controls.Add(label1);
            Controls.Add(gridviewHistoryTransaction);
            Name = "FrmTransactionHistory";
            Text = "Transaction History";
            FormClosing += FrmTransactionHistory_FormClosing;
            Load += FrmTransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)gridviewHistoryTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridviewHistoryTransaction;
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
        private Label label1;
        private TextBox txtSearchBox;
        private Button btnSearch;
        private PictureBox pictureBox1;
    }
}