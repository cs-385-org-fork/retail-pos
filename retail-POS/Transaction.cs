using System;
using System.Collections.Generic;
using System.Text;

namespace retail_POS
{
    internal class Transaction
    {
        private int id;
        private string saledate;
        private decimal taxamount;
        private decimal grandtotal;
        private int uniqueitemcount;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string SaleDate
        {
            get { return saledate; }
            set { saledate = value; }
        }
        public decimal TaxAmount
        {
            get { return taxamount; }
            set { taxamount = value; }
        }
        public decimal GrandTotal
        {
            get { return grandtotal; }
            set { grandtotal = value; }
        }

        public int UniqueItemCount
        {
            get { return  uniqueitemcount; }
            set { uniqueitemcount = value; }
        }

        public Transaction() { /* base constructor */ }

        public Transaction(int i, string sd, decimal ta, decimal gt)
        {
            id = i;
            saledate = sd;
            taxamount = ta;
            grandtotal = gt;
            uniqueitemcount = 0;
        }


    }
}
