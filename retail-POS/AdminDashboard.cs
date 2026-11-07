using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace retail_POS
{
    public partial class AdminDashboard : Form
    {
        DatabaseAccess dbAccess = new DatabaseAccess();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lBxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBxAddProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromInventory_Click(object sender, EventArgs e)
        {
            dbAccess.RemoveProduct(lBxInventory.SelectedIndex + 1);
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            dbAccess.AddProduct(tBxAddProduct.Text, 0, 0);
        }

        private void tbxChangeInStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbAccess.UpdateProductStock(lBxInventory.SelectedIndex + 1, Convert.ToInt32(tbxChangeInStock.Text));
            }
        }

        private void tbxChangePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbAccess.UpdateProductPrice(lBxInventory.SelectedIndex + 1, Convert.ToDecimal(tbxChangePrice.Text));
            }
        }
    }
}
