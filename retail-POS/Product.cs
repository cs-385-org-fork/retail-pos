using System;
using System.Collections.Generic;
using System.Text;

namespace retail_POS {
    internal class Product {
        private int id;
        private string name;
        private decimal price;
        private int quantity;

        public int ID {
            get { return id; }
            set { id = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public decimal Price {
            get { return price; }
            set { price = value; }
        }
        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product() { /* base constructor */ }

        public Product(int i, string nm, decimal pr, int quant) {
            id = i;
            name = nm;
            price = pr;
            quantity = quant;
        }


    }
}
