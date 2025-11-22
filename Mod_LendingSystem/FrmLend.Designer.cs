
namespace Mod_LendingSystem
{
    partial class FrmLend
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
            txtCustID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            dtpTransacDate = new DateTimePicker();
            label9 = new Label();
            txtMI = new TextBox();
            txtContactNo = new TextBox();
            label10 = new Label();
            txtAmount = new TextBox();
            cbInterestRate = new ComboBox();
            cbPaymentSched = new ComboBox();
            dtpDueDate = new DateTimePicker();
            label11 = new Label();
            btnLend = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.hand_money_svgrepo_com;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 130);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 22F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(145, 45);
            label1.Name = "label1";
            label1.Size = new Size(359, 50);
            label1.TabIndex = 3;
            label1.Text = "Lending Transaction";
            // 
            // txtCustID
            // 
            txtCustID.Font = new Font("Segoe UI", 10F);
            txtCustID.Location = new Point(172, 160);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(259, 30);
            txtCustID.TabIndex = 4;
            txtCustID.TextChanged += txtCustID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(471, 163);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 5;
            label2.Text = "Amount";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 6;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(12, 245);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 7;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F);
            label5.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label5.Location = new Point(471, 286);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 8;
            label5.Text = "Transaction Date";
            label5.Click += this.label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10F);
            label7.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label7.Location = new Point(471, 245);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 10;
            label7.Text = "Payment Schedule";
            label7.Click += this.label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10F);
            label8.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label8.Location = new Point(471, 204);
            label8.Name = "label8";
            label8.Size = new Size(127, 23);
            label8.TabIndex = 9;
            label8.Text = "Interest Rate %";
            label8.Click += this.label8_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F);
            label6.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label6.Location = new Point(12, 163);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 11;
            label6.Text = "Customer ID";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 10F);
            txtFirstname.Location = new Point(172, 201);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(259, 30);
            txtFirstname.TabIndex = 12;
            txtFirstname.TextChanged += txtFirstname_TextChanged;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 10F);
            txtLastname.Location = new Point(172, 242);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(259, 30);
            txtLastname.TabIndex = 13;
            txtLastname.TextChanged += txtLastname_TextChanged;
            // 
            // dtpTransacDate
            // 
            dtpTransacDate.CalendarFont = new Font("Segoe UI", 10F);
            dtpTransacDate.Location = new Point(659, 286);
            dtpTransacDate.Name = "dtpTransacDate";
            dtpTransacDate.Size = new Size(259, 27);
            dtpTransacDate.TabIndex = 14;
            dtpTransacDate.ValueChanged += dtpTransacDate_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10F);
            label9.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label9.Location = new Point(12, 286);
            label9.Name = "label9";
            label9.Size = new Size(110, 23);
            label9.TabIndex = 15;
            label9.Text = "Middle Initial";
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Segoe UI", 10F);
            txtMI.Location = new Point(172, 283);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(259, 30);
            txtMI.TabIndex = 16;
            txtMI.TextChanged += txtMI_TextChanged;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 10F);
            txtContactNo.Location = new Point(172, 323);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(259, 30);
            txtContactNo.TabIndex = 18;
            txtContactNo.TextChanged += txtContactNo_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10F);
            label10.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label10.Location = new Point(12, 326);
            label10.Name = "label10";
            label10.Size = new Size(102, 23);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.Location = new Point(659, 160);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(259, 30);
            txtAmount.TabIndex = 19;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // cbInterestRate
            // 
            cbInterestRate.Font = new Font("Segoe UI", 10F);
            cbInterestRate.FormattingEnabled = true;
            cbInterestRate.Location = new Point(659, 201);
            cbInterestRate.Name = "cbInterestRate";
            cbInterestRate.Size = new Size(259, 31);
            cbInterestRate.TabIndex = 20;
            cbInterestRate.SelectedIndexChanged += cbInterestRate_SelectedIndexChanged;
            // 
            // cbPaymentSched
            // 
            cbPaymentSched.Font = new Font("Segoe UI", 10F);
            cbPaymentSched.FormattingEnabled = true;
            cbPaymentSched.Location = new Point(659, 242);
            cbPaymentSched.Name = "cbPaymentSched";
            cbPaymentSched.Size = new Size(259, 31);
            cbPaymentSched.TabIndex = 21;
            cbPaymentSched.SelectedIndexChanged += cbPaymentSched_SelectedIndexChanged;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarFont = new Font("Segoe UI", 10F);
            dtpDueDate.Location = new Point(659, 323);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(259, 27);
            dtpDueDate.TabIndex = 23;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10F);
            label11.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label11.Location = new Point(471, 323);
            label11.Name = "label11";
            label11.Size = new Size(82, 23);
            label11.TabIndex = 22;
            label11.Text = "Due Date";
            // 
            // btnLend
            // 
            btnLend.BackColor = Color.FromArgb(128, 194, 48);
            btnLend.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnLend.FlatAppearance.BorderSize = 2;
            btnLend.FlatStyle = FlatStyle.Popup;
            btnLend.Font = new Font("Segoe UI", 18F);
            btnLend.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnLend.Location = new Point(745, 43);
            btnLend.Name = "btnLend";
            btnLend.Size = new Size(173, 59);
            btnLend.TabIndex = 24;
            btnLend.Text = "Lend";
            btnLend.UseVisualStyleBackColor = false;
            btnLend.Click += btnSubmit_Click;
            // 
            // FrmLend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(947, 378);
            Controls.Add(btnLend);
            Controls.Add(dtpDueDate);
            Controls.Add(label11);
            Controls.Add(cbPaymentSched);
            Controls.Add(cbInterestRate);
            Controls.Add(txtAmount);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(txtMI);
            Controls.Add(label9);
            Controls.Add(dtpTransacDate);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustID);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "FrmLend";
            Text = "Lend";
            FormClosing += FrmLend_FormClosing;
            Load += FrmLend_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtCustID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label6;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private DateTimePicker dtpTransacDate;
        private Label label9;
        private TextBox txtMI;
        private TextBox txtContactNo;
        private Label label10;
        private TextBox txtAmount;
        private ComboBox cbInterestRate;
        private ComboBox cbPaymentSched;
        private DateTimePicker dtpDueDate;
        private Label label11;
        private Button btnLend;
    }
}