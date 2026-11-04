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

        public AdminLogin() {
            InitializeComponent();

            udbaccess = new UserDatabaseAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            bool login = udbaccess.LogIn(tbxUsername.Text, tbxPassword.Text);

            if (login) {
                MessageBox.Show("Login successful!");
            }
            else {
                MessageBox.Show("Login failed.");
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            udbaccess.CreateUser(tbxUsername.Text, tbxPassword.Text);
        }

        private void btnSalt_Click(object sender, EventArgs e) {
            string salty = udbaccess.Salt(tbxPassword.Text);

            MessageBox.Show(salty);
        }
    }
}
