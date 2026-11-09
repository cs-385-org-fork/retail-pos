using System.Reflection.PortableExecutable;

namespace retail_POS {
    public partial class Form1 : Form
    {
        List<Product> availableProduct = new List<Product> { };
        List<Product> currentTransactionProducts = new List<Product> { };
        List<Product> allProducts = new List<Product> { };
        DatabaseAccess dbAccess = new DatabaseAccess();
        int quantityRequested = 1;
        decimal taxAmount = 0.00m;
        decimal taxPercent = 0.06m;
        int testID = 0;
        decimal cost = 0.00m;
        decimal totalCost = 0.00m;


        public void initializeLists()
        {
            //Pull the list from the database and put each product availableProduct. Make sure to check if the product has any stock and if not don't add to the list.
            availableProduct = dbAccess.ListProducts();
            availableProduct = availableProduct.Where(item => item.Quantity > 0).ToList();

            lbxAllProducts.DataSource = null;
            lbxAllProducts.DataSource = dbAccess.ListProducts();
            lbxAllProducts.DisplayMember = nameof(Product.Name);
            lbxAllProducts.ValueMember = nameof(Product.ID);

        }

        public void calculateTotal()
        {
            cost = 0;

            if (lbxCheckoutItems.Items.Count != 0)
            {
                foreach (Product item in currentTransactionProducts)
                {
                    cost += item.Price;
                }
            }
            taxAmount = cost * taxPercent;
            totalCost = cost + taxAmount;
            lblTotals.Text = $"Subtotal: {cost:C}    Tax: {taxAmount:C}    Total: {totalCost:C}";
        }

        public Form1()
        {
            InitializeComponent();
            initializeLists();
            lbxCheckoutItems.DisplayMember = nameof(Product.Name);
            lblClock.Text = DateTime.Now.ToString("hh:mm tt  MM/dd/yyyy");
            //(new AdminLogin()).Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int checkID = 0;
            //Try to convery barcode to an int first
            if (int.TryParse(tbxBarcode.Text, out int number))
            {
                checkID = number;
            }
            else
            {
                checkID = 0;
                tbxBarcode.Clear();
            }
            //If the barcode is over 0, check for item.
            if (checkID > 0)
            {
                bool itemFound = false;
                //Replace this with a faster loop later
                foreach (Product item in availableProduct)
                {
                    if (item.ID == checkID)
                    {
                        int currentAmount = currentTransactionProducts.Count(item => item.ID == checkID);
                        if (quantityRequested + currentAmount <= item.Quantity)
                            currentTransactionProducts.Add(item);
                        else { MessageBox.Show("Item out of stock."); }
                        itemFound = true;
                    }
                }
                if (itemFound == false)
                {
                    MessageBox.Show("Item ID not found.");
                    tbxBarcode.Clear();
                }
            }
            else
            {
                //If something is selected add it to the transaction.
                Product selectedProduct = (Product)lbxAllProducts.SelectedItem;

                //Check the amount of times it is already in cart
                int currentAmount = currentTransactionProducts.Count(Item => Item.ID == selectedProduct.ID);

                if (quantityRequested + currentAmount <= selectedProduct.Quantity)
                {
                    for (int i = 0; i < quantityRequested; i++)
                    {
                        currentTransactionProducts.Add(selectedProduct);
                        lbxCheckoutItems.Items.Add(selectedProduct);
                    }
                }
                else { MessageBox.Show("The item does not have enough stock."); }
            }
            //Change the string on the total box.
            calculateTotal();
        }

        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            //Create things that can be 
            List<Product> transactionProducts = new List<Product> { };
            Transaction newTransaction = new Transaction(testID, DateTime.Now.ToString(), taxAmount, cost);
            newTransaction.ID = 0; //Placeholder ID

            if (lbxCheckoutItems.Items.Count != 0)
            {
            }
            else
            {
                MessageBox.Show("There are no items in the list.");
            }
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            currentTransactionProducts.Clear();
            lbxCheckoutItems.Items.Clear();
            cost = 0;
            taxAmount = 0;
            totalCost = 0;
            calculateTotal();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm tt  MM/dd/yyyy");
        }

        private void lblClock_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantityRequested = (int)numQuantity.Value;
        }
    }
}
