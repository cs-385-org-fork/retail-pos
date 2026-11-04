using System.Reflection.PortableExecutable;

namespace retail_POS {
    public partial class Form1 : Form
    {
        List<Product> availableProduct = new List<Product> {};
        public Form1()
        {
            InitializeComponent();

            // (new AdminLogin()).Show();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
