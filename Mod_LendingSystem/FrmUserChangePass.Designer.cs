namespace Mod_LendingSystem
{
    partial class FrmUserChangePass
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
            txtConfrimNewPass = new TextBox();
            label3 = new Label();
            txtNewPass = new TextBox();
            label2 = new Label();
            btnUserChangePass = new Button();
            txtOldPass = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtConfrimNewPass
            // 
            txtConfrimNewPass.Location = new Point(15, 302);
            txtConfrimNewPass.Name = "txtConfrimNewPass";
            txtConfrimNewPass.Size = new Size(206, 27);
            txtConfrimNewPass.TabIndex = 21;
            txtConfrimNewPass.TextChanged += txtConfrimNewPass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 276);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 20;
            label3.Text = "Confirm Password:";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(15, 230);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(206, 27);
            txtNewPass.TabIndex = 19;
            txtNewPass.TextChanged += txtNewPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 204);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 18;
            label2.Text = "New Password:";
            // 
            // btnUserChangePass
            // 
            btnUserChangePass.BackColor = Color.FromArgb(128, 194, 48);
            btnUserChangePass.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnUserChangePass.FlatAppearance.BorderSize = 2;
            btnUserChangePass.FlatStyle = FlatStyle.Popup;
            btnUserChangePass.Font = new Font("Segoe UI", 12F);
            btnUserChangePass.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnUserChangePass.Location = new Point(71, 357);
            btnUserChangePass.Name = "btnUserChangePass";
            btnUserChangePass.Size = new Size(91, 44);
            btnUserChangePass.TabIndex = 17;
            btnUserChangePass.Text = "Change";
            btnUserChangePass.UseVisualStyleBackColor = false;
            btnUserChangePass.Click += btnUserChangePass_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(15, 166);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(206, 27);
            txtOldPass.TabIndex = 16;
            txtOldPass.TextChanged += txtOldPass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 140);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 15;
            label1.Text = "Old Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_svgrepo_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(65, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 107);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FrmUserChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(238, 417);
            Controls.Add(txtConfrimNewPass);
            Controls.Add(label3);
            Controls.Add(txtNewPass);
            Controls.Add(label2);
            Controls.Add(btnUserChangePass);
            Controls.Add(txtOldPass);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmUserChangePass";
            Text = "FrmUserChangePass";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtConfrimNewPass;
        private Label label3;
        private TextBox txtNewPass;
        private Label label2;
        private Button btnUserChangePass;
        private TextBox txtOldPass;
        private Label label1;
        private PictureBox pictureBox1;
    }
}