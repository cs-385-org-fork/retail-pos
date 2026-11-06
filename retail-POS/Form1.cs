using System.Reflection.PortableExecutable;

namespace retail_POS {
    public partial class Form1 : Form
    {
        List<Product> availableProduct = new List<Product> { };
        List<Product> currentTransactionProducts = new List<Product> { };

        public void initializeLists()
        {

        }

        public Form1()
        {
            InitializeComponent();

            // (new AdminLogin()).Show();
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
            }
            //If the barcode is over 0, check for item.
            if (checkID > 0)
            {
                foreach (Product item in availableProduct) 
                { 
                    if (item.ID == checkID)
                    {
                        currentTransactionProducts.Add(item);
                    }
                }
            }
            else
            {
                //If something is selected add it to the transaction.
                if (listBox1.SelectedIndex != -1)
                {
                    currentTransactionProducts.Add((Product)listBox1.SelectedItem);
                }
            }
        }

    }
}
