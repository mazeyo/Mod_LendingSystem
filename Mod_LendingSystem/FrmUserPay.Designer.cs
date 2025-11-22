namespace Mod_LendingSystem
{
    partial class FrmUserPay
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
            dtpUserTransacDate = new DateTimePicker();
            label5 = new Label();
            btnPaySubmit = new Button();
            label1 = new Label();
            label6 = new Label();
            txtCustID = new TextBox();
            txtAmount = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblUInterestAmount = new Label();
            lblUTotalBal = new Label();
            lblUBorrowedAmount = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpUserTransacDate
            // 
            dtpUserTransacDate.CalendarFont = new Font("Segoe UI", 10F);
            dtpUserTransacDate.Location = new Point(189, 361);
            dtpUserTransacDate.Name = "dtpUserTransacDate";
            dtpUserTransacDate.Size = new Size(259, 27);
            dtpUserTransacDate.TabIndex = 48;
            dtpUserTransacDate.ValueChanged += dtpUserTransacDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F);
            label5.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label5.Location = new Point(12, 364);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 47;
            label5.Text = "Transaction Date";
            // 
            // btnPaySubmit
            // 
            btnPaySubmit.BackColor = Color.FromArgb(128, 194, 48);
            btnPaySubmit.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnPaySubmit.FlatAppearance.BorderSize = 2;
            btnPaySubmit.FlatStyle = FlatStyle.Popup;
            btnPaySubmit.Font = new Font("Segoe UI", 12F);
            btnPaySubmit.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnPaySubmit.Location = new Point(162, 416);
            btnPaySubmit.Name = "btnPaySubmit";
            btnPaySubmit.Size = new Size(125, 40);
            btnPaySubmit.TabIndex = 46;
            btnPaySubmit.Text = "Submit";
            btnPaySubmit.UseVisualStyleBackColor = false;
            btnPaySubmit.Click += btnPaySubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 37);
            label1.TabIndex = 45;
            label1.Text = "Pay";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F);
            label6.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 43;
            label6.Text = "Customer ID";
            // 
            // txtCustID
            // 
            txtCustID.Font = new Font("Segoe UI", 10F);
            txtCustID.Location = new Point(189, 281);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(259, 30);
            txtCustID.TabIndex = 42;
            txtCustID.TextChanged += txtCustID_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.Location = new Point(189, 321);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(259, 30);
            txtAmount.TabIndex = 40;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(12, 324);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 38;
            label2.Text = "Amount";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.hand_money_svgrepo_com__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 70);
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // lblUInterestAmount
            // 
            lblUInterestAmount.AutoSize = true;
            lblUInterestAmount.BackColor = Color.Transparent;
            lblUInterestAmount.Font = new Font("Segoe UI Semibold", 10F);
            lblUInterestAmount.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblUInterestAmount.Location = new Point(271, 147);
            lblUInterestAmount.Name = "lblUInterestAmount";
            lblUInterestAmount.Size = new Size(95, 23);
            lblUInterestAmount.TabIndex = 62;
            lblUInterestAmount.Text = "0000000.00";
            lblUInterestAmount.Click += lblUInterestAmount_Click;
            // 
            // lblUTotalBal
            // 
            lblUTotalBal.AutoSize = true;
            lblUTotalBal.BackColor = Color.Transparent;
            lblUTotalBal.Font = new Font("Segoe UI Semibold", 10F);
            lblUTotalBal.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblUTotalBal.Location = new Point(271, 231);
            lblUTotalBal.Name = "lblUTotalBal";
            lblUTotalBal.Size = new Size(95, 23);
            lblUTotalBal.TabIndex = 61;
            lblUTotalBal.Text = "0000000.00";
            lblUTotalBal.Click += lblUTotalBal_Click;
            // 
            // lblUBorrowedAmount
            // 
            lblUBorrowedAmount.AutoSize = true;
            lblUBorrowedAmount.BackColor = Color.Transparent;
            lblUBorrowedAmount.Font = new Font("Segoe UI Semibold", 10F);
            lblUBorrowedAmount.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblUBorrowedAmount.Location = new Point(271, 106);
            lblUBorrowedAmount.Name = "lblUBorrowedAmount";
            lblUBorrowedAmount.Size = new Size(95, 23);
            lblUBorrowedAmount.TabIndex = 60;
            lblUBorrowedAmount.Text = "0000000.00";
            lblUBorrowedAmount.Click += lblUBorrowedAmount_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10F);
            label7.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label7.Location = new Point(48, 187);
            label7.Name = "label7";
            label7.Size = new Size(353, 23);
            label7.TabIndex = 59;
            label7.Text = "-------------------------------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10F);
            label8.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label8.Location = new Point(72, 147);
            label8.Name = "label8";
            label8.Size = new Size(135, 23);
            label8.TabIndex = 58;
            label8.Text = "Interest Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label3.Location = new Point(72, 229);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 57;
            label3.Text = "Total Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(72, 106);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 56;
            label4.Text = "Borrowed Amount";
            // 
            // FrmUserPay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(480, 465);
            Controls.Add(lblUInterestAmount);
            Controls.Add(lblUTotalBal);
            Controls.Add(lblUBorrowedAmount);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(dtpUserTransacDate);
            Controls.Add(label5);
            Controls.Add(btnPaySubmit);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(txtCustID);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Name = "FrmUserPay";
            Text = "FrmUserPay";
            Load += FrmUserPay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpUserTransacDate;
        private Label label5;
        private Button btnPaySubmit;
        private Label label1;
        private Label label6;
        private TextBox txtCustID;
        private TextBox txtAmount;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblUInterestAmount;
        private Label lblUTotalBal;
        private Label lblUBorrowedAmount;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
    }
}