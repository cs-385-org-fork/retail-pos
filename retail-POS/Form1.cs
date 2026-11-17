using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace retail_POS {
    public partial class Form1 : Form {
        List<Product> availableProduct = new List<Product> { };
        List<Product> currentTransactionProducts = new List<Product> { };
        List<TransactionLineItem> currentTLIs = new List<TransactionLineItem> { };
        List<Product> allProducts = new List<Product> { };
        DatabaseAccess dbAccess = new DatabaseAccess();
        int quantityRequested = 1;
        decimal taxAmount = 0.00m;
        decimal taxPercent = 0.06m;
        int testID = 0;
        decimal cost = 0.00m;
        decimal totalCost = 0.00m;


        public void initializeLists() {
            //Pull the list from the database and put each product availableProduct. Make sure to check if the product has any stock and if not don't add to the list.
            availableProduct = dbAccess.ListProducts();
            availableProduct = availableProduct.Where(item => item.Quantity > 0).ToList();

            lbxAllProducts.DataSource = null;
            lbxAllProducts.DataSource = dbAccess.ListProducts();
            lbxAllProducts.DisplayMember = nameof(Product.Name);
            lbxAllProducts.ValueMember = nameof(Product.ID);

        }

        public void calculateTotal() {
            cost = 0;

            if (lbxCheckoutItems.Items.Count != 0) {
                foreach (Product item in currentTransactionProducts) {
                    cost += item.Price;
                }
            }
            taxAmount = cost * taxPercent;
            totalCost = cost + taxAmount;
            //lblTotals.Text = $"Subtotal: {}    Tax: {:C}    Total: {:C}";
            lblTotals.Text = "Subtotal:\t " + cost.ToString("C2") + "\n"
                           + "Tax:\t " + taxAmount.ToString("C2") + "\n"
                           + "Total:\t " + totalCost.ToString("C2");
        }



        public Form1() {
            InitializeComponent();
            calculateTotal();
            initializeLists();
            lbxCheckoutItems.DisplayMember = nameof(Product.Name);
            lblClock.Text = DateTime.Now.ToString("hh:mm tt  MM/dd/yyyy");
            lblTotals.Text = "Subtotal:\t $00.00" + "\n"
                           + "Tax:\t $00.00" + "\n"
                           + "Total:\t $00.00";
            //(new AdminLogin()).Show();
        }


        public void ReloadForm() {
            initializeLists();
        }

        public void OpenAdminDashboard()
        {
            new AdminDashboard(this).Show();
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            int checkID = 0;
            //Try to convery barcode to an int first
            if (int.TryParse(tbxBarcode.Text, out int number)) {
                checkID = number;
            }
            else {
                checkID = 0;
                tbxBarcode.Clear();
            }
            //If the barcode is over 0, check for item.
            if (checkID > 0) {
                bool itemFound = false;
                //Replace this with a faster loop later
                foreach (Product item in availableProduct) {
                    if (item.ID == checkID) {
                        int currentAmount = currentTransactionProducts.Count(item => item.ID == checkID);
                        if (quantityRequested + currentAmount <= item.Quantity) {
                            currentTransactionProducts.Add(item);
                            currentTLIs.Add(new TransactionLineItem(item, new Transaction(), item.ID, quantityRequested));
                            lbxCheckoutItems.Items.Add(item);
                        }
                        else { MessageBox.Show("Item out of stock."); }
                        itemFound = true;
                    }
                }
                if (itemFound == false) {
                    MessageBox.Show("Item ID not found.");
                    tbxBarcode.Clear();
                }
            }
            else {
                //If something is selected add it to the transaction.
                Product selectedProduct = (Product)lbxAllProducts.SelectedItem;

                //Check the amount of times it is already in cart
                int currentAmount = currentTransactionProducts.Count(Item => Item.ID == selectedProduct.ID);

                if (lbxAllProducts.Items.Count == 0) { MessageBox.Show("There are no product available right now"); }
                else if (quantityRequested + currentAmount <= selectedProduct.Quantity) {
                    for (int i = 0; i < quantityRequested; i++) {
                        currentTransactionProducts.Add(selectedProduct);
                        currentTLIs.Add(new TransactionLineItem(selectedProduct, new Transaction(), selectedProduct.ID, quantityRequested));
                        lbxCheckoutItems.Items.Add(selectedProduct);
                    }
                }
                else { MessageBox.Show("The item does not have enough stock."); }
            }
            //Change the string on the total box.
            calculateTotal();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e) {
            if (lbxCheckoutItems.SelectedIndex == -1) {
                MessageBox.Show("No Item is selected.");
            }
            else {
                currentTransactionProducts.RemoveAt(lbxCheckoutItems.SelectedIndex);
                lbxCheckoutItems.Items.RemoveAt(lbxCheckoutItems.SelectedIndex);

                calculateTotal();
            }
        }

        private void btnFinishTransaction_Click(object sender, EventArgs e) {
            if (lbxCheckoutItems.Items.Count != 0) {
                List<TransactionLineItem> transactionProducts = new List<TransactionLineItem> { };
                calculateTotal();

                string timeString = DateTime.Now.ToString();
                Transaction newTransaction = new Transaction(testID, timeString, taxAmount, cost);
                dbAccess.AddTransaction(newTransaction); //Send the transaction to the database
                newTransaction.ID = dbAccess.GetTransaction(timeString).ID; // get this transaction's ID

                /*int itemQuantity = 1;
                int Iid = 0;

                foreach (Product product in currentTransactionProducts) {
                    transactionProducts.Add( new TransactionLineItem(product, newTransaction, itemQuantity, Iid) );
                    Iid++;
                    //Check the quantity of each item, remove them from the database, and send the quantity + item as a transactionItem
                    foreach (TransactionLineItem checkProduct in transactionProducts) {
                        if (checkProduct.ProductID != product.ID) {
                            //TransactionLineItem newItem = new TransactionLineItem(product, newTransaction, itemQuantity, Iid);
                            transactionProducts.Add(new TransactionLineItem(product, newTransaction, itemQuantity, Iid));
                            Iid++;
                        }
                        else {
                            checkProduct.Quantity++;
                        }
                    }
                    dbAccess.DecrementStock(product.ID, 1);
                }

                foreach (TransactionLineItem newTransLineItem in transactionProducts) { //Convert the list of line items from transactionProducts into the database
                    dbAccess.AddTransactionLineItem(newTransLineItem.TransactionID, newTransLineItem.ProductID, newTransLineItem.Quantity);
                }*/

                foreach (Product product in currentTransactionProducts) {
                    dbAccess.DecrementStock(product.ID, 1);
                }

                foreach (TransactionLineItem newTransLineItem in currentTLIs) { //Convert the list of line items from transactionProducts into the database
                    dbAccess.AddTransactionLineItem(newTransaction.ID, newTransLineItem.ProductID, newTransLineItem.Quantity);
                }

                MessageBox.Show("Transaction complete!");
            }
            else {
                MessageBox.Show("There are no items in the list.");
                return;
            }
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e) {
            currentTransactionProducts.Clear();
            lbxCheckoutItems.Items.Clear();
            cost = 0;
            taxAmount = 0;
            totalCost = 0;
            calculateTotal();
        }

        private void clockTimer_Tick(object sender, EventArgs e) {
            lblClock.Text = DateTime.Now.ToString("hh:mm tt  MM/dd/yyyy");
        }

        private void lblClock_Click(object sender, EventArgs e) {
            //new AdminDashboard(this).Show();

            new AdminLogin(this).Show();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e) {
            quantityRequested = (int)numQuantity.Value;
        }

        
    }
}
