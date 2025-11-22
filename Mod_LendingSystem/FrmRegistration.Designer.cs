
namespace Mod_LendingSystem
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            splitContainer1 = new SplitContainer();
            btnRegister = new Button();
            label7 = new Label();
            txtPassConfirmation = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtUsername = new TextBox();
            label4 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtFname = new TextBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(143, 168, 84);
            splitContainer1.Panel1.Controls.Add(btnRegister);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(txtPassConfirmation);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(txtPassword);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(txtUsername);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(txtLName);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtFname);
            splitContainer1.Panel1.Controls.Add(linkLabel1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel2.BackgroundImage");
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(837, 502);
            splitContainer1.SplitterDistance = 358;
            splitContainer1.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(116, 385);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 32);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Sign In";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 318);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 16;
            label7.Text = "Confirm Password";
            // 
            // txtPassConfirmation
            // 
            txtPassConfirmation.Font = new Font("Segoe UI", 9F);
            txtPassConfirmation.Location = new Point(55, 341);
            txtPassConfirmation.Name = "txtPassConfirmation";
            txtPassConfirmation.Size = new Size(241, 27);
            txtPassConfirmation.TabIndex = 15;
            txtPassConfirmation.UseSystemPasswordChar = true;
            txtPassConfirmation.TextChanged += txtPassConfirmation_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 258);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(55, 281);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 199);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 12;
            label5.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(55, 222);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 11;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 140);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 10;
            label4.Text = "Last Name";
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Segoe UI", 9F);
            txtLName.Location = new Point(55, 163);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(241, 27);
            txtLName.TabIndex = 9;
            txtLName.TextChanged += txtLName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 80);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 8;
            label3.Text = "First Name";
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Segoe UI", 9F);
            txtFname.Location = new Point(55, 103);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(241, 27);
            txtFname.TabIndex = 3;
            txtFname.TextChanged += txtFname_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.Location = new Point(142, 460);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 23);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(42, 51, 23);
            label2.Location = new Point(84, 437);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 1;
            label2.Text = "If you have an account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(42, 51, 23);
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 0;
            label1.Text = "Account Registration";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 502);
            Controls.Add(splitContainer1);
            Name = "FrmRegistration";
            Text = "Registration";
            FormClosing += FrmRegistration_FormClosing;
            Load += FrmRegistration_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txtFname;
        private Label label7;
        private TextBox txtPassConfirmation;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtUsername;
        private Label label4;
        private TextBox txtLName;
        private Label label3;
        private Button btnRegister;
    }
}
