using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace retail_POS {
    internal class DatabaseAccess {

        private const string ConnectionString = "Data Source=LibraryCatalog.db";
        public DatabaseAccess() {
            InitializeDatabase();
        }
        public void InitializeDatabase() {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = " CREATE TABLE IF NOT EXISTS Products(ID INTEGER PRIMARY KEY, Name STRING NOT NULL, Price NOT NULL, Quantity NOT NULL)";
                    command.ExecuteNonQuery();

                    command.CommandText = " CREATE TABLE IF NOT EXISTS Transactions(ID INTEGER PRIMARY KEY, SaleDate STRING NOT NULL, TaxAmount DOUBLE, GrandTotal DOUBLE NOT NULL)";
                    command.ExecuteNonQuery();

                    command.CommandText = " CREATE TABLE IF NOT EXISTS TransactionLineItems(ID INTEGER PRIMARY KEY, TransactionID INTEGER NOT NULL, ProductID INTEGER NOT NULL, Quantity INTEGER NOT NULL, LineTotal DOUBLE NOT NULL, "
                                                                                               + "FOREIGN KEY (TransactionID) REFERENCES Products(ID), FOREIGN KEY (ProductID) REFERENCES Transactions(ID) )";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                // THIS IS BAD, DO NOT DO THIS:
                MessageBox.Show("Error initializing database.\t" + ex.Message);
            }
        }


    }
}