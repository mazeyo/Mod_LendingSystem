namespace Mod_LendingSystem
{
    partial class FrmPay
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtCustID = new TextBox();
            txtFirstname = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnPay = new Button();
            btnCalcBill = new Button();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblInterestAmount = new Label();
            lblTotalBal = new Label();
            lblBorrowedAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.hand_money_svgrepo_com__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 98);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(116, 29);
            label1.Name = "label1";
            label1.Size = new Size(304, 41);
            label1.TabIndex = 4;
            label1.Text = "Payment Transaction";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F);
            label6.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label6.Location = new Point(26, 124);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 31;
            label6.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(26, 187);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 25;
            label2.Text = "Amount to Pay";
            // 
            // txtCustID
            // 
            txtCustID.Font = new Font("Segoe UI", 10F);
            txtCustID.Location = new Point(166, 122);
            txtCustID.Margin = new Padding(3, 2, 3, 2);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(227, 25);
            txtCustID.TabIndex = 24;
            txtCustID.TextChanged += txtCustID_TextChanged;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 10F);
            txtFirstname.Location = new Point(166, 184);
            txtFirstname.Margin = new Padding(3, 2, 3, 2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(227, 25);
            txtFirstname.TabIndex = 32;
            txtFirstname.TextChanged += txtFirstname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label3.Location = new Point(26, 217);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 44;
            label3.Text = "Transaction Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(166, 214);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 45;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(128, 194, 48);
            btnPay.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnPay.FlatAppearance.BorderSize = 2;
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.Font = new Font("Segoe UI", 18F);
            btnPay.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnPay.Location = new Point(591, 28);
            btnPay.Margin = new Padding(3, 2, 3, 2);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(151, 44);
            btnPay.TabIndex = 46;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCalcBill
            // 
            btnCalcBill.BackColor = Color.FromArgb(128, 194, 48);
            btnCalcBill.FlatStyle = FlatStyle.Popup;
            btnCalcBill.Location = new Point(218, 152);
            btnCalcBill.Margin = new Padding(3, 2, 3, 2);
            btnCalcBill.Name = "btnCalcBill";
            btnCalcBill.Size = new Size(116, 22);
            btnCalcBill.TabIndex = 47;
            btnCalcBill.Text = "Calculate Bill";
            btnCalcBill.UseVisualStyleBackColor = false;
            btnCalcBill.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10F);
            label7.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label7.Location = new Point(442, 185);
            label7.Name = "label7";
            label7.Size = new Size(303, 19);
            label7.TabIndex = 51;
            label7.Text = "-------------------------------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10F);
            label8.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label8.Location = new Point(442, 154);
            label8.Name = "label8";
            label8.Size = new Size(110, 19);
            label8.TabIndex = 50;
            label8.Text = "Interest Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F);
            label5.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label5.Location = new Point(442, 216);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 49;
            label5.Text = "Total Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(442, 124);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 48;
            label4.Text = "Borrowed Amount";
            label4.Click += label4_Click;
            // 
            // lblInterestAmount
            // 
            lblInterestAmount.AutoSize = true;
            lblInterestAmount.BackColor = Color.Transparent;
            lblInterestAmount.Font = new Font("Segoe UI Semibold", 10F);
            lblInterestAmount.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblInterestAmount.Location = new Point(616, 154);
            lblInterestAmount.Name = "lblInterestAmount";
            lblInterestAmount.Size = new Size(84, 19);
            lblInterestAmount.TabIndex = 55;
            lblInterestAmount.Text = "0000000.00";
            // 
            // lblTotalBal
            // 
            lblTotalBal.AutoSize = true;
            lblTotalBal.BackColor = Color.Transparent;
            lblTotalBal.Font = new Font("Segoe UI Semibold", 10F);
            lblTotalBal.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblTotalBal.Location = new Point(616, 218);
            lblTotalBal.Name = "lblTotalBal";
            lblTotalBal.Size = new Size(84, 19);
            lblTotalBal.TabIndex = 54;
            lblTotalBal.Text = "0000000.00";
            lblTotalBal.Click += lblTotalBal_Click;
            // 
            // lblBorrowedAmount
            // 
            lblBorrowedAmount.AutoSize = true;
            lblBorrowedAmount.BackColor = Color.Transparent;
            lblBorrowedAmount.Font = new Font("Segoe UI Semibold", 10F);
            lblBorrowedAmount.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblBorrowedAmount.Location = new Point(616, 124);
            lblBorrowedAmount.Name = "lblBorrowedAmount";
            lblBorrowedAmount.Size = new Size(84, 19);
            lblBorrowedAmount.TabIndex = 53;
            lblBorrowedAmount.Text = "0000000.00";
            // 
            // FrmPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(765, 274);
            Controls.Add(lblInterestAmount);
            Controls.Add(lblTotalBal);
            Controls.Add(lblBorrowedAmount);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCalcBill);
            Controls.Add(btnPay);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtFirstname);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtCustID);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPay";
            Text = "Pay";
            FormClosing += FrmPay_FormClosing;
            Load += FrmPay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label6;
        private Label label2;
        private TextBox txtCustID;
        private TextBox txtFirstname;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnPay;
        private Button btnCalcBill;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label lblInterestAmount;
        private Label lblTotalBal;
        private Label lblBorrowedAmount;
    }
}