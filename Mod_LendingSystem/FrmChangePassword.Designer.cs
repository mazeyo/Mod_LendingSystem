namespace Mod_LendingSystem
{
    partial class FrmChangePassword
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
            btnChangePass = new Button();
            txtOldPass = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtNewPass = new TextBox();
            label2 = new Label();
            txtConfrimNewPass = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.FromArgb(128, 194, 48);
            btnChangePass.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnChangePass.FlatAppearance.BorderSize = 2;
            btnChangePass.FlatStyle = FlatStyle.Popup;
            btnChangePass.Font = new Font("Segoe UI", 12F);
            btnChangePass.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnChangePass.Location = new Point(96, 357);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(91, 44);
            btnChangePass.TabIndex = 9;
            btnChangePass.Text = "Change";
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(40, 166);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.Size = new Size(206, 27);
            txtOldPass.TabIndex = 8;
            txtOldPass.TextChanged += txtOldPass_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(40, 140);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 7;
            label1.Text = "Old Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_svgrepo_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(85, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 105);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(40, 230);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(206, 27);
            txtNewPass.TabIndex = 11;
            txtNewPass.TextChanged += txtNewPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 204);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 10;
            label2.Text = "New Password:";
            // 
            // txtConfrimNewPass
            // 
            txtConfrimNewPass.Location = new Point(40, 302);
            txtConfrimNewPass.Name = "txtConfrimNewPass";
            txtConfrimNewPass.Size = new Size(206, 27);
            txtConfrimNewPass.TabIndex = 13;
            txtConfrimNewPass.TextChanged += txtConfrimNewPass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(40, 276);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password:";
            // 
            // FrmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(289, 426);
            Controls.Add(txtConfrimNewPass);
            Controls.Add(label3);
            Controls.Add(txtNewPass);
            Controls.Add(label2);
            Controls.Add(btnChangePass);
            Controls.Add(txtOldPass);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmChangePassword";
            Text = "Change Password";
            FormClosing += FrmChangePassword_FormClosing;
            Load += FrmChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangePass;
        private TextBox txtOldPass;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtNewPass;
        private Label label2;
        private TextBox txtConfrimNewPass;
        private Label label3;
    }
}