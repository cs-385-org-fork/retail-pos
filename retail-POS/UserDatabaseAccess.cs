using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace retail_POS {
    internal class UserDatabaseAccess : DatabaseAccess {

        private const string ConnectionString = "Data Source=UserData.db";
        private const string SaltStr = "P3pp#r";

        public override void InitializeDatabase() {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" CREATE TABLE IF NOT EXISTS Administrators(ID INTEGER PRIMARY KEY, Username STRING NOT NULL, Password STRING NOT NULL)");
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

    }
}
