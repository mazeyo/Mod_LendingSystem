namespace Mod_LendingSystem
{
    partial class FrmUserLend
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
            cbUserPaymentSched = new ComboBox();
            txtAmount = new TextBox();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtCustID = new TextBox();
            label1 = new Label();
            btnLendSubmit = new Button();
            dtpUserTransacDate = new DateTimePicker();
            label5 = new Label();
            txtUserContactNo = new TextBox();
            label10 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cbUserPaymentSched
            // 
            cbUserPaymentSched.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserPaymentSched.Font = new Font("Segoe UI", 10F);
            cbUserPaymentSched.FormattingEnabled = true;
            cbUserPaymentSched.Location = new Point(193, 213);
            cbUserPaymentSched.Name = "cbUserPaymentSched";
            cbUserPaymentSched.Size = new Size(259, 31);
            cbUserPaymentSched.TabIndex = 27;
            cbUserPaymentSched.SelectedIndexChanged += cbUserPaymentSched_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10F);
            txtAmount.Location = new Point(193, 173);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(259, 30);
            txtAmount.TabIndex = 25;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10F);
            label7.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label7.Location = new Point(16, 216);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 24;
            label7.Text = "Payment Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(16, 176);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 22;
            label2.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10F);
            label6.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label6.Location = new Point(16, 136);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 29;
            label6.Text = "Customer ID";
            // 
            // txtCustID
            // 
            txtCustID.Font = new Font("Segoe UI", 10F);
            txtCustID.Location = new Point(193, 133);
            txtCustID.Name = "txtCustID";
            txtCustID.Size = new Size(259, 30);
            txtCustID.TabIndex = 28;
            txtCustID.TextChanged += txtCustID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(95, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 37);
            label1.TabIndex = 31;
            label1.Text = "Borrow";
            label1.Click += label1_Click;
            // 
            // btnLendSubmit
            // 
            btnLendSubmit.BackColor = Color.FromArgb(128, 194, 48);
            btnLendSubmit.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnLendSubmit.FlatAppearance.BorderSize = 2;
            btnLendSubmit.FlatStyle = FlatStyle.Popup;
            btnLendSubmit.Font = new Font("Segoe UI", 12F);
            btnLendSubmit.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnLendSubmit.Location = new Point(167, 360);
            btnLendSubmit.Name = "btnLendSubmit";
            btnLendSubmit.Size = new Size(125, 40);
            btnLendSubmit.TabIndex = 32;
            btnLendSubmit.Text = "Submit";
            btnLendSubmit.UseVisualStyleBackColor = false;
            btnLendSubmit.Click += btnLendSubmit_Click;
            // 
            // dtpUserTransacDate
            // 
            dtpUserTransacDate.CalendarFont = new Font("Segoe UI", 10F);
            dtpUserTransacDate.Location = new Point(193, 291);
            dtpUserTransacDate.Name = "dtpUserTransacDate";
            dtpUserTransacDate.Size = new Size(259, 27);
            dtpUserTransacDate.TabIndex = 34;
            dtpUserTransacDate.ValueChanged += dtpUserTransacDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10F);
            label5.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label5.Location = new Point(16, 294);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 33;
            label5.Text = "Transaction Date";
            // 
            // txtUserContactNo
            // 
            txtUserContactNo.Font = new Font("Segoe UI", 10F);
            txtUserContactNo.Location = new Point(193, 252);
            txtUserContactNo.Name = "txtUserContactNo";
            txtUserContactNo.Size = new Size(259, 30);
            txtUserContactNo.TabIndex = 36;
            txtUserContactNo.TextChanged += txtUserContactNo_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10F);
            label10.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label10.Location = new Point(16, 255);
            label10.Name = "label10";
            label10.Size = new Size(102, 23);
            label10.TabIndex = 35;
            label10.Text = "Contact No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8F);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(269, 9);
            label4.Name = "label4";
            label4.Size = new Size(199, 57);
            label4.TabIndex = 37;
            label4.Text = "Note*\r\nCannot borrow when account \r\nstill has balance";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.hand_money_svgrepo_com;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 70);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // FrmUserLend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(480, 412);
            Controls.Add(label4);
            Controls.Add(txtUserContactNo);
            Controls.Add(label10);
            Controls.Add(dtpUserTransacDate);
            Controls.Add(label5);
            Controls.Add(btnLendSubmit);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(txtCustID);
            Controls.Add(cbUserPaymentSched);
            Controls.Add(txtAmount);
            Controls.Add(label7);
            Controls.Add(label2);
            Name = "FrmUserLend";
            Text = "FrmUserLend";
            FormClosing += FrmUserLend_FormClosing;
            Load += FrmUserLend_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUserPaymentSched;
        private TextBox txtAmount;
        private Label label7;
        private Label label2;
        private Label label6;
        private TextBox txtCustID;
        private Label label1;
        private Button btnLendSubmit;
        private DateTimePicker dtpUserTransacDate;
        private Label label5;
        private TextBox txtUserContactNo;
        private Label label10;
        private Label label4;
        private PictureBox pictureBox2;
    }
}