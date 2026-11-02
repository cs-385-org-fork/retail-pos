using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace retail_POS {
    internal class DatabaseAccess {

        private const string ConnectionString = "Data Source=ShopData.db";

        public DatabaseAccess() {
            InitializeDatabase();
        }

        public void InitializeDatabase() {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" CREATE TABLE IF NOT EXISTS Products(ID INTEGER PRIMARY KEY, Name STRING NOT NULL, Price NOT NULL, Quantity NOT NULL)");
                    command.ExecuteNonQuery();

                    command.CommandText = (" CREATE TABLE IF NOT EXISTS Transactions(ID INTEGER PRIMARY KEY, SaleDate STRING NOT NULL, TaxAmount DOUBLE, GrandTotal DOUBLE NOT NULL)");
                    command.ExecuteNonQuery();

                    command.CommandText = (" CREATE TABLE IF NOT EXISTS TransactionLineItems(ID INTEGER PRIMARY KEY, TransactionID INTEGER NOT NULL, ProductID INTEGER NOT NULL, Quantity INTEGER NOT NULL, LineTotal DOUBLE NOT NULL, "
                                                                                               + "FOREIGN KEY (TransactionID) REFERENCES Products(ID), FOREIGN KEY (ProductID) REFERENCES Transactions(ID) )");
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error initializing database.\t" + ex.Message);
            }
        }

        public void AddProduct(string name, double price, int quantity) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (@" INSERT INTO Products(Name, Price, Quantity) 
                                                                VALUES(@name, @price, @quantity); ");
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to add product to database.\t" + ex.Message);
            }
        }
        public void UpdateProduct(int id, string name, double price, int quantity) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" UPDATE Products SET Name = '" + name + "', Price = " + price + ", Quantity = " + quantity + "  WHERE ID = " + id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to update product information in database.\t" + ex.Message);
            }
        }
        public void RemoveProduct(int id) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" DELETE FROM Products WHERE ID = " + id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to remove product from database.\t" + ex.Message);
            }
        }
        public List<Product> ListProducts() {
            List<Product> catalog = new List<Product>();

            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = @" SELECT * FROM Products";

                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            catalog.Add( new Product(reader.GetInt32(0), /* ID */
                                                        reader.GetString(1), /* Name */
                                                        reader.GetDecimal(2), /* Price */
                                                        reader.GetInt32(3) /* Quantity */ ) );
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to access products from database.\t" + ex.Message);
            }

            return catalog;
        }
        public void DecrementStock(int id, int amount) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" SELECT Quantity FROM Products WHERE ID = " + id);

                    int currentStock;
                    using (var reader = command.ExecuteReader()) {
                        currentStock = reader.GetInt32(0);
                    }

                    command.CommandText = (" UPDATE Products SET Quantity = " + (currentStock - amount) + "WHERE ID = " + id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to update stock in database.\t" + ex.Message);
            }
        }

    }
}