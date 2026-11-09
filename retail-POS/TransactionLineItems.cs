using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace retail_POS
{
    internal class TransactionLineItem
    {
        private int id;
        private int transactionid;
        private int productid;
        private int quantity;
        private decimal linetotal;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int TransactionID
        {
            get { return transactionid; }
            set { transactionid = value; }
        }
        public int ProductID
        {
            get { return productid; }
            set { productid = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal LineTotal
        {
            get { return linetotal; }
            set { linetotal = value; }
        }

        public TransactionLineItem() { /* base constructor */ }

        public TransactionLineItem(int i, int tid, int pid, int q, decimal lt)
        {
            id = i;
            transactionid = tid;
            productid = pid;
            quantity = q;
            linetotal = lt;
        }


        public TransactionLineItem(Product product, Transaction transaction, int q, int i)
        {
            id = transaction.UniqueItemCount; //Potentially add + 1 here
            transactionid = transaction.ID;
            productid = product.ID;
            linetotal = q * product.Price;
        }

    }
}
