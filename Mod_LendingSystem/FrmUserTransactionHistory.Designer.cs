namespace Mod_LendingSystem
{
    partial class FrmUserTransactionHistory
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
            dgvUserTransacHistory = new DataGridView();
            clmnCategory = new DataGridViewTextBoxColumn();
            clmnAmount = new DataGridViewTextBoxColumn();
            clmnDatr = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserTransacHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvUserTransacHistory
            // 
            dgvUserTransacHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserTransacHistory.Columns.AddRange(new DataGridViewColumn[] { clmnCategory, clmnAmount, clmnDatr });
            dgvUserTransacHistory.Location = new Point(12, 101);
            dgvUserTransacHistory.Name = "dgvUserTransacHistory";
            dgvUserTransacHistory.RowHeadersWidth = 51;
            dgvUserTransacHistory.Size = new Size(428, 337);
            dgvUserTransacHistory.TabIndex = 0;
            dgvUserTransacHistory.CellContentClick += dgvUserTransacHistory_CellContentClick;
            // 
            // clmnCategory
            // 
            clmnCategory.HeaderText = "Category";
            clmnCategory.MinimumWidth = 6;
            clmnCategory.Name = "clmnCategory";
            clmnCategory.ReadOnly = true;
            clmnCategory.Width = 125;
            // 
            // clmnAmount
            // 
            clmnAmount.HeaderText = "Amount";
            clmnAmount.MinimumWidth = 6;
            clmnAmount.Name = "clmnAmount";
            clmnAmount.ReadOnly = true;
            clmnAmount.Width = 125;
            // 
            // clmnDatr
            // 
            clmnDatr.HeaderText = "Date";
            clmnDatr.MinimumWidth = 6;
            clmnDatr.Name = "clmnDatr";
            clmnDatr.ReadOnly = true;
            clmnDatr.Width = 125;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(128, 194, 48);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 37);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(109, 54);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 2;
            label1.Text = "Transaction History";
            label1.Click += label1_Click;
            // 
            // FrmUserTransactionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(454, 450);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvUserTransacHistory);
            Name = "FrmUserTransactionHistory";
            Text = "FrmUserTransactionHistory";
            Load += FrmUserTransactionHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserTransacHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUserTransacHistory;
        private DataGridViewTextBoxColumn clmnCategory;
        private DataGridViewTextBoxColumn clmnAmount;
        private DataGridViewTextBoxColumn clmnDatr;
        private Button btnBack;
        private Label label1;
    }
}