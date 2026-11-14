namespace retail_POS {
    partial class AdminLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            lblLoginTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            btnCreateUser = new Button();
            btnSalt = new Button();
            SuspendLayout();
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(49, 9);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(227, 25);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Log In to Dashboard";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(12, 51);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(17, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // tbxUsername
            // 
            tbxUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.Location = new Point(93, 48);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(214, 27);
            tbxUsername.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(93, 81);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(214, 27);
            tbxPassword.TabIndex = 4;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(93, 123);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUser.Location = new Point(93, 169);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(140, 40);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnSalt
            // 
            btnSalt.BackColor = SystemColors.ActiveCaption;
            btnSalt.Location = new Point(162, 233);
            btnSalt.Name = "btnSalt";
            btnSalt.Size = new Size(150, 40);
            btnSalt.TabIndex = 7;
            btnSalt.Text = "Super Secret Button for Screenshot Purposes";
            btnSalt.UseVisualStyleBackColor = false;
            btnSalt.Click += btnSalt_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(324, 285);
            Controls.Add(btnSalt);
            Controls.Add(btnCreateUser);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLoginTitle);
            Name = "AdminLogin";
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Button btnCreateUser;
        private Button btnSalt;
    }
}