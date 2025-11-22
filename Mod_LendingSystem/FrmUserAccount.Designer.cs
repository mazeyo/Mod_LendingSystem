namespace Mod_LendingSystem
{
    partial class FrmUserAccount
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
            label1 = new Label();
            lblNameUser = new Label();
            btnChangePass = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.user_svgrepo_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 69);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Underline);
            label1.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label1.Location = new Point(101, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 12;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNameUser
            // 
            lblNameUser.AutoSize = true;
            lblNameUser.BackColor = Color.Transparent;
            lblNameUser.Font = new Font("Segoe UI Semibold", 20F);
            lblNameUser.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblNameUser.Location = new Point(101, 44);
            lblNameUser.Name = "lblNameUser";
            lblNameUser.Size = new Size(205, 37);
            lblNameUser.TabIndex = 11;
            lblNameUser.Text = "Dela Cruz, Juan\r\n";
            lblNameUser.TextAlign = ContentAlignment.TopCenter;
            lblNameUser.Click += lblNameUser_Click;
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
            btnChangePass.Location = new Point(275, 231);
            btnChangePass.Margin = new Padding(3, 2, 3, 2);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(38, 24);
            btnChangePass.TabIndex = 21;
            btnChangePass.UseVisualStyleBackColor = false;
            btnChangePass.Click += btnChangePass_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 14F);
            lblPassword.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblPassword.Location = new Point(32, 276);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 25);
            lblPassword.TabIndex = 20;
            lblPassword.Text = "**********";
            lblPassword.TextAlign = ContentAlignment.TopCenter;
            lblPassword.Click += lblPassword_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI Semibold", 14F);
            lblUsername.ForeColor = Color.FromArgb(44, 51, 27, 20);
            lblUsername.Location = new Point(32, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 25);
            lblUsername.TabIndex = 19;
            lblUsername.Text = "qwerty";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            lblUsername.Click += lblUsername_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Underline);
            label4.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label4.Location = new Point(10, 227);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 18;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Underline);
            label2.ForeColor = Color.FromArgb(44, 51, 27, 20);
            label2.Location = new Point(10, 128);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 17;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmUserAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(336, 338);
            Controls.Add(btnChangePass);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNameUser);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUserAccount";
            Text = "S";
            Load += FrmUserAccount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblNameUser;
        private Button btnChangePass;
        private Label lblPassword;
        private Label lblUsername;
        private Label label4;
        private Label label2;
    }
}