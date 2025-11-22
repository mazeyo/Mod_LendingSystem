namespace Mod_LendingSystem
{
    partial class FrmUserTransaction
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            lblCurrentBal = new Label();
            label3 = new Label();
            btnBorrow = new Button();
            label4 = new Label();
            lblDuedatePayment = new Label();
            btnPay = new Button();
            label1 = new Label();
            label5 = new Label();
            menuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            editPasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.money_cash_svgrepo_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 86);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.philippines_peso_currency_symbol_svgrepo_com;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(12, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 49);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Underline);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 6;
            label2.Text = "Current Balance:";
            // 
            // lblCurrentBal
            // 
            lblCurrentBal.AutoSize = true;
            lblCurrentBal.BackColor = Color.Transparent;
            lblCurrentBal.Font = new Font("Segoe UI Semibold", 20F);
            lblCurrentBal.ForeColor = Color.FromArgb(36, 43, 20);
            lblCurrentBal.Location = new Point(52, 164);
            lblCurrentBal.Name = "lblCurrentBal";
            lblCurrentBal.Size = new Size(161, 46);
            lblCurrentBal.TabIndex = 7;
            lblCurrentBal.Text = "00000.00";
            lblCurrentBal.Click += lblCurrentBal_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 18F);
            label3.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label3.Location = new Point(130, 16);
            label3.Name = "label3";
            label3.Size = new Size(232, 82);
            label3.TabIndex = 8;
            label3.Text = "Money Lending\r\nSystem";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.FromArgb(128, 194, 48);
            btnBorrow.BackgroundImage = Properties.Resources.hand_money_svgrepo_com;
            btnBorrow.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrow.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnBorrow.FlatAppearance.BorderSize = 2;
            btnBorrow.FlatStyle = FlatStyle.Popup;
            btnBorrow.Font = new Font("Segoe UI", 18F);
            btnBorrow.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnBorrow.Location = new Point(68, 301);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(118, 72);
            btnBorrow.TabIndex = 13;
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Underline);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(274, 135);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 14;
            label4.Text = "Due Date:";
            // 
            // lblDuedatePayment
            // 
            lblDuedatePayment.AutoSize = true;
            lblDuedatePayment.BackColor = Color.Transparent;
            lblDuedatePayment.Font = new Font("Segoe UI Semibold", 12F);
            lblDuedatePayment.ForeColor = Color.FromArgb(36, 43, 20);
            lblDuedatePayment.Location = new Point(274, 171);
            lblDuedatePayment.Name = "lblDuedatePayment";
            lblDuedatePayment.Size = new Size(138, 28);
            lblDuedatePayment.TabIndex = 15;
            lblDuedatePayment.Text = "June 02, 2025";
            lblDuedatePayment.Click += lblDuedatePayment_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(128, 194, 48);
            btnPay.BackgroundImage = Properties.Resources.hand_money_svgrepo_com__1_;
            btnPay.BackgroundImageLayout = ImageLayout.Zoom;
            btnPay.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnPay.FlatAppearance.BorderSize = 2;
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.Font = new Font("Segoe UI", 18F);
            btnPay.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnPay.Location = new Point(267, 301);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(118, 72);
            btnPay.TabIndex = 16;
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(87, 260);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 17;
            label1.Text = "Borrow";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F);
            label5.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label5.Location = new Point(308, 260);
            label5.Name = "label5";
            label5.Size = new Size(43, 28);
            label5.TabIndex = 18;
            label5.Text = "Pay";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Transparent;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RightToLeft = RightToLeft.Yes;
            menuStrip.Size = new Size(456, 28);
            menuStrip.TabIndex = 19;
            menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionsToolStripMenuItem, accountToolStripMenuItem, signOutToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(224, 26);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editPasswordToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(224, 26);
            accountToolStripMenuItem.Text = "Account";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // editPasswordToolStripMenuItem
            // 
            editPasswordToolStripMenuItem.Name = "editPasswordToolStripMenuItem";
            editPasswordToolStripMenuItem.Size = new Size(224, 26);
            editPasswordToolStripMenuItem.Text = "Edit Password";
            editPasswordToolStripMenuItem.Click += editPasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(224, 26);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // FrmUserTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(456, 414);
            Controls.Add(menuStrip);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnPay);
            Controls.Add(lblDuedatePayment);
            Controls.Add(label4);
            Controls.Add(btnBorrow);
            Controls.Add(label3);
            Controls.Add(lblCurrentBal);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FrmUserTransaction";
            Text = "Transaction";
            FormClosing += FrmUserTransaction_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label lblCurrentBal;
        private Label label3;
        private Button btnBorrow;
        private Label label4;
        private Label lblDuedatePayment;
        private Button btnPay;
        private Label label1;
        private Label label5;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem editPasswordToolStripMenuItem;
    }
}