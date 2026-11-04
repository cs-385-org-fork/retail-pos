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
        private void InitializeComponent() {
            label1 = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            btnCreateUser = new Button();
            btnSalt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(433, 15);
            label1.TabIndex = 0;
            label1.Text = "this is subject to change i just want to test the stuff in UserDatabaseAccess -miles";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(188, 122);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(191, 151);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(254, 119);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(214, 23);
            tbxUsername.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(254, 148);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(214, 23);
            tbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(311, 191);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Location = new Point(311, 220);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(75, 23);
            btnCreateUser.TabIndex = 6;
            btnCreateUser.Text = "Create User";
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnSalt
            // 
            btnSalt.Location = new Point(311, 249);
            btnSalt.Name = "btnSalt";
            btnSalt.Size = new Size(75, 23);
            btnSalt.TabIndex = 7;
            btnSalt.Text = "mmm salty";
            btnSalt.UseVisualStyleBackColor = true;
            btnSalt.Click += btnSalt_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalt);
            Controls.Add(btnCreateUser);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Button btnCreateUser;
        private Button btnSalt;
    }
}