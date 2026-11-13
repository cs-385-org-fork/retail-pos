using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace retail_POS {
    internal class DatabaseAccess {

        private const string ConnectionString = "Data Source=ShopData.db";
        private string? connnectionString;

        public DatabaseAccess() {
            InitializeDatabase();
        }

        public virtual void InitializeDatabase() {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" CREATE TABLE IF NOT EXISTS Products(ID INTEGER PRIMARY KEY AUTOINCREMENT, Name STRING NOT NULL, Price NOT NULL, Quantity NOT NULL)");
                    command.ExecuteNonQuery();

                    command.CommandText = (" CREATE TABLE IF NOT EXISTS Transactions(ID INTEGER PRIMARY KEY AUTOINCREMENT, SaleDate STRING NOT NULL, TaxAmount DOUBLE, GrandTotal DOUBLE NOT NULL)");
                    command.ExecuteNonQuery();

                    command.CommandText = (" CREATE TABLE IF NOT EXISTS TransactionLineItems(ID INTEGER PRIMARY KEY AUTOINCREMENT, TransactionID INTEGER NOT NULL, ProductID INTEGER NOT NULL, Quantity INTEGER NOT NULL, LineTotal DOUBLE NOT NULL, "
                                                                                               + "FOREIGN KEY (TransactionID) REFERENCES Products(ID), FOREIGN KEY (ProductID) REFERENCES Transactions(ID) )");
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error initializing database.\t" + ex.Message);
            }
        }


        //PRODUCT METHODS
        public void AddProduct(string name, double price, int quantity) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (@" INSERT INTO Products(Name, Price, Quantity) 
                                                                VALUES(@name, @price, @quantity); ");
                    //command.Parameters.AddWithValue("@id", id);
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
        public void AddProduct(Product prod) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    //command.CommandText = (@"")
                    command.CommandText = (@" INSERT INTO Products( Name, Price, Quantity) 
                                                                VALUES(@name, @price, @quantity); ");
                   // command.Parameters.AddWithValue("@id", prod.ID);
                    command.Parameters.AddWithValue("@name", prod.Name);
                    command.Parameters.AddWithValue("@price", prod.Price);
                    command.Parameters.AddWithValue("@quantity", prod.Quantity);

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
        public void UpdateProductStock(int id, int quantity)
        {
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" UPDATE Products SET Quantity = " + quantity + " WHERE ID = " + id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product information in database.\t" + ex.Message);
            }
        }
        public void UpdateProductPrice(int id, decimal price)
        {
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" UPDATE Products SET Price = " + price + " WHERE ID = " + id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product information in database.\t" + ex.Message);
            }
        }
        public List<Product> AllProducts(List<Product> products) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = (" SELECT * FROM Products");
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            products.Add(new Product
                            {
                                ID = Convert.ToInt32(reader.GetValue(0)),
                                Name = reader.GetString(1),
                                Price = Convert.ToDecimal(reader.GetValue(2)),
                                Quantity = Convert.ToInt32(reader.GetValue(3))
                            });
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to access products from database.\t" + ex.Message);
            }
            return products;
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
        public Product GetProduct(int id) {
            Product prod = new Product();

            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" SELECT * FROM Products WHERE ID = " + id);

                    using (var reader = command.ExecuteReader()) {
                        prod.ID = reader.GetInt32(0); /* ID */
                        prod.Name = reader.GetString(1); /* Name */
                        prod.Price = reader.GetDecimal(2); /* Price */
                        prod.Quantity = reader.GetInt32(3); /* Quantity */
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to access product from database.\t" + ex.Message);
            }

            return prod;
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
                            catalog.Add(new Product(
                                Convert.ToInt32(reader.GetValue(0)),
                                reader.GetString(1),
                                Convert.ToDecimal(reader.GetValue(2)),
                                Convert.ToInt32(reader.GetValue(3))));
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

                    int currentStock = 0;
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            currentStock = reader.GetInt32(0);
                        }
                    }
                    
                    command.CommandText = (" UPDATE Products SET Quantity = " + (currentStock - amount) + " WHERE ID = " + id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to update stock in database.\t" + ex.Message);
            }
        }


        // TRANSACTION METHODS
        public void AddTransaction(string date, decimal tax, decimal grandtotal) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (@" INSERT INTO Transactions(SaleDate, TaxAmount, GrandTotal) 
                                                                VALUES(@date, @tax, @grandtotal); ");
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@tax", tax);
                    command.Parameters.AddWithValue("@grandtotal", grandtotal);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to add transaction to database.\t" + ex.Message);
            }
        }
        public void AddTransaction(Transaction trans) {
            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (@" INSERT INTO Transactions(SaleDate, TaxAmount, GrandTotal) 
                                                                VALUES(@date, @tax, @grandtotal); ");
                    command.Parameters.AddWithValue("@date", trans.SaleDate);
                    command.Parameters.AddWithValue("@tax", trans.TaxAmount);
                    command.Parameters.AddWithValue("@grandtotal", trans.GrandTotal);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to add transaction to database.\t" + ex.Message);
            }
        }
        public Transaction GetTransaction(int id) {
            Transaction trans = new Transaction();

            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (" SELECT * FROM Transactions WHERE ID = " + id);

                    using (var reader = command.ExecuteReader()) {
                        trans.ID = reader.GetInt32(0); /* ID */
                        trans.SaleDate = reader.GetString(1); /* SaleDate */
                        trans.TaxAmount = reader.GetDecimal(2); /* TaxAmount */
                        trans.GrandTotal = reader.GetDecimal(3); /* GrandTotal */
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to access transaction from database.\t" + ex.Message);
            }

            return trans;
        }
        public List<Transaction> ListTransactions() {
            List<Transaction> transLog = new List<Transaction>();

            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = @" SELECT * FROM Transactions";

                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            transLog.Add(new Transaction(reader.GetInt32(0), /* ID */
                                                        reader.GetString(1), /* SaleDate */
                                                        reader.GetDecimal(2), /* TaxAmount */
                                                        reader.GetDecimal(3) /* GrandTotal */ ));
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to access transactions from database.\t" + ex.Message);
            }

            return transLog;
        }


        // TRANSACTIONLINEITEMS METHODS
        public void AddTransactionLineItem(int transid, int prodid, int quantity) {
            decimal prodPrice = GetProduct(prodid).Price; // get product price
            decimal linetotal = prodPrice * quantity; // calculate line total

            try {
                using (var connection = new SqliteConnection(ConnectionString)) {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = (@" INSERT INTO TransactionLineItems(TransactionID, ProductID, Quantity, LineTotal) 
                                                                VALUES(@transid, @prodid, @quantity, @linetotal); ");
                    command.Parameters.AddWithValue("@transid", transid);
                    command.Parameters.AddWithValue("@prodid", prodid);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@linetotal", linetotal);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to add transaction to database.\t" + ex.Message);
            }


        }
        public void ResetDB()
        {
            using (var connection = new SqliteConnection(connnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM TransactionLineItems;";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM sqlite_sequence WHERE name = 'TransactionLineItems';"; // this magic command resets the auto increment
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM Transactions;";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM sqlite_sequence WHERE name = 'Transactions';"; // this magic command resets the auto increment
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM Products;";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM sqlite_sequence WHERE name = 'Products';"; // this magic command resets the auto increment
                    command.ExecuteNonQuery();
                }
            }
        }


    }
}