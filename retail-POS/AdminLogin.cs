using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace retail_POS {
    public partial class AdminLogin : Form {

        UserDatabaseAccess udbaccess;
        Form1 register;

        public AdminLogin(Form1 reg) {
            InitializeComponent();

            udbaccess = new UserDatabaseAccess();
            register = reg;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            bool login = udbaccess.LogIn(tbxUsername.Text, tbxPassword.Text);

            if (login) {
                MessageBox.Show("Login successful!");

                register.OpenAdminDashboard();
                this.Close();
            }
            else {
                MessageBox.Show("Login failed.");
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            udbaccess.CreateUser(tbxUsername.Text, tbxPassword.Text);
        }

        private void btnSalt_Click(object sender, EventArgs e) {

            MessageBox.Show("User: " + tbxUsername.Text + "\n\nStored Password: " + udbaccess.GetSaltedPassword(tbxUsername.Text));
        }
    }
}
