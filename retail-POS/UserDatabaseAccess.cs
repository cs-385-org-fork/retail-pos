using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace retail_POS {
    internal class UserDatabaseAccess : DatabaseAccess {

        private const string ConnectionString = "Data Source=UserData.db";
        private const string SaltStr = "P3pp#r";

        public UserDatabaseAccess() {
            InitializeDatabase();
        }

        public override void InitializeDatabase() {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" CREATE TABLE IF NOT EXISTS Administrators(ID INTEGER PRIMARY KEY, Username STRING UNIQUE NOT NULL, Password STRING NOT NULL)");
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error initializing database.\t" + ex.Message);
            }
        }


        public string Salt(string pword) {
            Stream pwordAndSalt = new MemoryStream(Encoding.UTF8.GetBytes( pword + SaltStr ));

            SHA256 hash = SHA256.Create();
            byte[] hashValue = hash.ComputeHash(pwordAndSalt);

            return ( BitConverter.ToString(hashValue) );
        }


        public void CreateUser(string uname, string pword) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" INSERT INTO Administrators (Username,Password) Values ('" + uname + "', '" + Salt(pword) + "') ");
                    command.ExecuteNonQuery();

                    MessageBox.Show("User \"" + uname + "\" has been created!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error creating new user.\t" + ex.Message);
            }
        }
        public bool LogIn(string uname, string pword) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" SELECT Password FROM Administrators WHERE Username = '" + uname + "'");

                    string storedPword = "";

                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read())
                        {
                            storedPword = reader.GetString(0);
                        }
                    }

                    if ( storedPword == Salt(pword) ) {
                        return true; // password is correct
                    }
                    else {
                        MessageBox.Show("Incorrect password.");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to log in.\t" + ex.Message);
            }
            
            return false;
        }
        public string GetSaltedPassword(string uname) { // THIS IS FOR TESTING, I AM GOING TO DELETE IT LATER
            string salty = "";
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" SELECT Password FROM Administrators WHERE Username = '" + uname + "'");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            salty = reader.GetString(0);
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to retrieve information from database.\t" + ex.Message);
            }
            return salty;
        }

    }
}
