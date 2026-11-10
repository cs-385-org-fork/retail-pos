using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace retail_POS
{
    public partial class AdminDashboard : Form {
        DatabaseAccess dbAccess = new DatabaseAccess();
        Form1 register;

        private int selectedProduct = 0;

        public AdminDashboard(Form1 reg) {
            InitializeComponent();

            register = reg;

            LoadInventory();
        }

        private void lBxInventory_SelectedIndexChanged(object sender, EventArgs e) {
            if (lBxInventory.SelectedItem is Product product) {
                lblInStockValue.Text = product.Quantity.ToString();
                lblPriceValue.Text = product.Price.ToString("0.00");
            }
            else
            {
                lblInStockValue.Text = "0";
                lblPriceValue.Text = "0.00";
            }
        }
        private void lBxInventory_Click(object sender, EventArgs e) {
            selectedProduct = lBxInventory.SelectedIndex;
        }
        private void AdminDashboard_Load(object sender, EventArgs e) {
            LoadInventory();
        }
        private void tBxAddProduct_TextChanged(object sender, EventArgs e) {

        }

        private void btnRemoveFromInventory_Click(object sender, EventArgs e) {
            if (lBxInventory.SelectedItem is Product product) {
                dbAccess.RemoveProduct(product.ID);
                LoadInventory();
            }
        }

        private void LoadInventory() {
            lBxInventory.DataSource = null;
            lBxInventory.DataSource = dbAccess.ListProducts();
            lBxInventory.DisplayMember = nameof(Product.Name);
            lBxInventory.ValueMember = nameof(Product.ID);
            if (lBxInventory.Items.Count != 0)
            {
                lBxInventory.SelectedIndex = selectedProduct;
            }
            
        }
        private void btnAddToInventory_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(tBxAddProduct.Text)) {
                dbAccess.AddProduct(tBxAddProduct.Text.Trim(), 0, 0);
                tBxAddProduct.Clear();
                LoadInventory();
            }
        }

        private void tbxChangeInStock_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (lBxInventory.SelectedItem is Product product &&
                    int.TryParse(tbxChangeInStock.Text, out int quantity)) {
                    dbAccess.UpdateProductStock(product.ID, quantity);
                    LoadInventory();
                }
            }
        }

        private void tbxChangePrice_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (lBxInventory.SelectedItem is Product product &&
                    decimal.TryParse(tbxChangePrice.Text, out decimal price)) {
                    dbAccess.UpdateProductPrice(product.ID, price);
                    LoadInventory();
                }
            }
<<<<<<< HEAD
        }

        private void lblInStockValue_Click(object sender, EventArgs e)
        {

        }
=======
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e) {
            register.Show(); // re-open Form1 when AdminDashboard is closed
            register.ReloadForm();
        }

>>>>>>> 48d6ce5ea52492ca3581ad4c3baed4705a9199d8
    }
}
