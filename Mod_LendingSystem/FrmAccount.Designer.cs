namespace Mod_LendingSystem
{
    partial class FrmAccount
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
            lblNameUser = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            btnChangePass = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_svgrepo_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 132);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNameUser
            // 
            lblNameUser.AutoSize = true;
            lblNameUser.BackColor = Color.Transparent;
            lblNameUser.Font = new Font("Segoe UI Semibold", 20F);
            lblNameUser.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblNameUser.Location = new Point(158, 80);
            lblNameUser.Name = "lblNameUser";
            lblNameUser.Size = new Size(256, 46);
            lblNameUser.TabIndex = 9;
            lblNameUser.Text = "Dela Cruz, Juan\r\n";
            lblNameUser.TextAlign = ContentAlignment.TopCenter;
            lblNameUser.Click += lblNameUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Underline);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(158, 43);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Underline);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(12, 189);
            label2.Name = "label2";
            label2.Size = new Size(147, 37);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Underline);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(12, 261);
            label4.Name = "label4";
            label4.Size = new Size(139, 37);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI Semibold", 14F);
            lblUsername.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblUsername.Location = new Point(199, 194);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(90, 32);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "qwerty";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 14F);
            lblPassword.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblPassword.Location = new Point(199, 266);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 32);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "**********";
            lblPassword.TextAlign = ContentAlignment.TopCenter;
            lblPassword.Click += lblPassword_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.BackColor = Color.Transparent;
            btnChangePass.BackgroundImage = Properties.Resources.edit;
            btnChangePass.BackgroundImageLayout = ImageLayout.Zoom;
            btnChangePass.FlatAppearance.BorderColor = Color.FromArgb(128, 194, 48);
            btnChangePass.FlatAppearance.BorderSize = 0;
            btnChangePass.FlatStyle = FlatStyle.Flat;
            btnChangePass.Font = new Font("Segoe UI", 18F);
            btnChangePass.ForeColor = Color.FromArgb(44, 51, 27, 20);
            btnChangePass.Location = new Point(387, 261);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(44, 32);
            btnChangePass.TabIndex = 16;
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += button1_Click;
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(469, 331);
            Controls.Add(btnChangePass);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNameUser);
            Controls.Add(pictureBox1);
            Name = "FrmAccount";
            Text = "Account Profile";
            FormClosing += FrmAccount_FormClosing;
            Load += FrmAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNameUser;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnChangePass;
    }
}