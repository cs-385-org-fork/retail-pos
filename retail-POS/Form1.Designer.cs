namespace retail_POS {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddItem = new Button();
            lbxCheckoutItems = new ListBox();
            tbxBarcode = new TextBox();
            btnCancelTransaction = new Button();
            btnFinishTransaction = new Button();
            lbxAllProducts = new ListBox();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(548, 334);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(240, 45);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lbxCheckoutItems
            // 
            lbxCheckoutItems.FormattingEnabled = true;
            lbxCheckoutItems.Location = new Point(12, 12);
            lbxCheckoutItems.Name = "lbxCheckoutItems";
            lbxCheckoutItems.Size = new Size(530, 364);
            lbxCheckoutItems.TabIndex = 2;
            // 
            // tbxBarcode
            // 
            tbxBarcode.Location = new Point(548, 12);
            tbxBarcode.Name = "tbxBarcode";
            tbxBarcode.Size = new Size(240, 27);
            tbxBarcode.TabIndex = 3;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.Location = new Point(12, 382);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(184, 65);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.Text = "Cancel Transaction";
            btnCancelTransaction.UseVisualStyleBackColor = true;
            btnCancelTransaction.Click += btnCancelTransaction_Click;
            // 
            // btnFinishTransaction
            // 
            btnFinishTransaction.Location = new Point(548, 385);
            btnFinishTransaction.Name = "btnFinishTransaction";
            btnFinishTransaction.Size = new Size(240, 62);
            btnFinishTransaction.TabIndex = 5;
            btnFinishTransaction.Text = "Finish Transaction";
            btnFinishTransaction.UseVisualStyleBackColor = true;
            btnFinishTransaction.Click += btnFinishTransaction_Click;
            // 
            // lbxAllProducts
            // 
            lbxAllProducts.FormattingEnabled = true;
            lbxAllProducts.Location = new Point(548, 45);
            lbxAllProducts.Name = "lbxAllProducts";
            lbxAllProducts.Size = new Size(240, 284);
            lbxAllProducts.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbxAllProducts);
            Controls.Add(btnFinishTransaction);
            Controls.Add(btnCancelTransaction);
            Controls.Add(tbxBarcode);
            Controls.Add(lbxCheckoutItems);
            Controls.Add(btnAddItem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddItem;
        private ListBox listBox1;
        private ListBox lbxCheckoutItems;
        private TextBox tbxBarcode;
        private Button btnCancelTransaction;
        private Button btnFinishTransaction;
        private ListBox lbxAllProducts;
    }
}
