namespace Mod_LendingSystem
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            txtPassLogIn = new TextBox();
            label5 = new Label();
            txtUnameLogin = new TextBox();
            btnLogIn = new Button();
            linkLabelSignin = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 83);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F);
            label1.Location = new Point(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 181);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 18;
            label6.Text = "Password";
            // 
            // txtPassLogIn
            // 
            txtPassLogIn.Font = new Font("Segoe UI", 9F);
            txtPassLogIn.Location = new Point(33, 198);
            txtPassLogIn.Margin = new Padding(3, 2, 3, 2);
            txtPassLogIn.Name = "txtPassLogIn";
            txtPassLogIn.Size = new Size(211, 23);
            txtPassLogIn.TabIndex = 17;
            txtPassLogIn.UseSystemPasswordChar = true;
            txtPassLogIn.TextChanged += txtPassLogIn_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 136);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 16;
            label5.Text = "Username";
            // 
            // txtUnameLogin
            // 
            txtUnameLogin.Font = new Font("Segoe UI", 9F);
            txtUnameLogin.Location = new Point(33, 154);
            txtUnameLogin.Margin = new Padding(3, 2, 3, 2);
            txtUnameLogin.Name = "txtUnameLogin";
            txtUnameLogin.Size = new Size(211, 23);
            txtUnameLogin.TabIndex = 15;
            txtUnameLogin.TextChanged += txtUnameLogin_TextChanged;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(83, 238);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(98, 24);
            btnLogIn.TabIndex = 19;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // linkLabelSignin
            // 
            linkLabelSignin.AutoSize = true;
            linkLabelSignin.Font = new Font("Segoe UI", 9F);
            linkLabelSignin.Location = new Point(106, 295);
            linkLabelSignin.Name = "linkLabelSignin";
            linkLabelSignin.Size = new Size(43, 15);
            linkLabelSignin.TabIndex = 22;
            linkLabelSignin.TabStop = true;
            linkLabelSignin.Text = "Sign In";
            linkLabelSignin.LinkClicked += linkLabelSignin_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(42, 51, 23);
            label2.Location = new Point(62, 280);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 21;
            label2.Text = "Don't have an account?";
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 168, 84);
            ClientSize = new Size(280, 326);
            Controls.Add(linkLabelSignin);
            Controls.Add(label2);
            Controls.Add(btnLogIn);
            Controls.Add(label6);
            Controls.Add(txtPassLogIn);
            Controls.Add(label5);
            Controls.Add(txtUnameLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogIn";
            Text = "LogIn";
            FormClosing += FrmLogIn_FormClosing;
            Load += FrmLogIn_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private TextBox txtPassLogIn;
        private Label label5;
        private TextBox txtUnameLogin;
        private Button btnLogIn;
        private LinkLabel linkLabelSignin;
        private Label label2;
    }
}