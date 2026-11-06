using System.Reflection.PortableExecutable;

namespace retail_POS {
    public partial class Form1 : Form
    {
        List<Product> availableProduct = new List<Product> { };
        List<Product> currentTransactionProducts = new List<Product> { };
        

        public void initializeLists()
        {
            //Pull the list from the database and put each product availableProduct

        }

        public Form1()
        {
            InitializeComponent();
            initializeLists();
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
                        currentTransactionProducts.Add(item);
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
                if (lbxAllProducts.Items.Count != 0)
                {
                    if (lbxAllProducts.SelectedIndex != -1)
                    {
                        currentTransactionProducts.Add((Product)lbxAllProducts.SelectedItem);
                        lbxCheckoutItems.Items.Add(lbxAllProducts.SelectedItem);
                    }
                }

            }
        }

        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            //Create things that can be 
            List<Product> transactionProducts = new List<Product> { };
            decimal taxAmount = 0.0m;
            int testID = 0;
            decimal cost = 0.00m;
            Transaction newTransaction = new Transaction(testID, DateTime.Now.ToString(), taxAmount, cost);
            newTransaction.ID = 0; //Placeholder ID

            if (lbxCheckoutItems.Items.Count != 0)
            {
                foreach (Product item in currentTransactionProducts)
                { 
                    
                }
                }
            else
            {
                MessageBox.Show("There are no items in the list.");
            }
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            lbxCheckoutItems.Items.Clear();
        }
    }
}
