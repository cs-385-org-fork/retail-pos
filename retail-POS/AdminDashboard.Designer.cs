namespace retail_POS
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            tBxAddProduct = new TextBox();
            label1 = new Label();
            lBxInventory = new ListBox();
            label2 = new Label();
            lblInStock = new Label();
            lblInStockValue = new Label();
            tbxChangeInStock = new TextBox();
            label3 = new Label();
            lblPrice = new Label();
            lblPriceValue = new Label();
            tbxChangePrice = new TextBox();
            label4 = new Label();
            btnAddToInventory = new Button();
            btnRemoveFromInventory = new Button();
            SuspendLayout();
            // 
            // tBxAddProduct
            // 
            tBxAddProduct.BackColor = SystemColors.InactiveCaption;
            tBxAddProduct.Location = new Point(55, 51);
            tBxAddProduct.Margin = new Padding(2, 1, 2, 1);
            tBxAddProduct.Name = "tBxAddProduct";
            tBxAddProduct.Size = new Size(166, 23);
            tBxAddProduct.TabIndex = 0;
            tBxAddProduct.TextChanged += tBxAddProduct_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(55, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 18);
            label1.TabIndex = 1;
            label1.Text = "Enter Product Name";
            // 
            // lBxInventory
            // 
            lBxInventory.BackColor = SystemColors.InactiveCaption;
            lBxInventory.ForeColor = SystemColors.ActiveCaptionText;
            lBxInventory.FormattingEnabled = true;
            lBxInventory.Location = new Point(55, 130);
            lBxInventory.Margin = new Padding(2, 1, 2, 1);
            lBxInventory.Name = "lBxInventory";
            lBxInventory.Size = new Size(166, 124);
            lBxInventory.TabIndex = 2;
            lBxInventory.Click += lBxInventory_Click;
            lBxInventory.SelectedIndexChanged += lBxInventory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 18);
            label2.TabIndex = 3;
            label2.Text = "Current Inventory";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(230, 130);
            lblInStock.Margin = new Padding(2, 0, 2, 0);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(99, 15);
            lblInStock.TabIndex = 4;
            lblInStock.Text = "Amount In Stock:";
            // 
            // lblInStockValue
            // 
            lblInStockValue.AutoSize = true;
            lblInStockValue.Location = new Point(339, 130);
            lblInStockValue.Margin = new Padding(2, 0, 2, 0);
            lblInStockValue.Name = "lblInStockValue";
            lblInStockValue.Size = new Size(25, 15);
            lblInStockValue.TabIndex = 5;
            lblInStockValue.Text = "000";
            // 
            // tbxChangeInStock
            // 
            tbxChangeInStock.BackColor = SystemColors.InactiveCaption;
            tbxChangeInStock.Location = new Point(230, 166);
            tbxChangeInStock.Margin = new Padding(2, 1, 2, 1);
            tbxChangeInStock.Name = "tbxChangeInStock";
            tbxChangeInStock.Size = new Size(153, 23);
            tbxChangeInStock.TabIndex = 6;
            tbxChangeInStock.KeyDown += tbxChangeInStock_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 150);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 7;
            label3.Text = "Change Amount In Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(230, 198);
            lblPrice.Margin = new Padding(2, 0, 2, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(39, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price: ";
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.Location = new Point(275, 198);
            lblPriceValue.Margin = new Padding(2, 0, 2, 0);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(25, 15);
            lblPriceValue.TabIndex = 9;
            lblPriceValue.Text = "000";
            // 
            // tbxChangePrice
            // 
            tbxChangePrice.BackColor = SystemColors.InactiveCaption;
            tbxChangePrice.Location = new Point(230, 229);
            tbxChangePrice.Margin = new Padding(2, 1, 2, 1);
            tbxChangePrice.Name = "tbxChangePrice";
            tbxChangePrice.Size = new Size(110, 23);
            tbxChangePrice.TabIndex = 10;
            tbxChangePrice.KeyDown += tbxChangePrice_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 213);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 11;
            label4.Text = "Change Price";
            // 
            // btnAddToInventory
            // 
            btnAddToInventory.BackColor = SystemColors.ScrollBar;
            btnAddToInventory.ForeColor = SystemColors.HotTrack;
            btnAddToInventory.Location = new Point(245, 49);
            btnAddToInventory.Margin = new Padding(2, 1, 2, 1);
            btnAddToInventory.Name = "btnAddToInventory";
            btnAddToInventory.Size = new Size(79, 38);
            btnAddToInventory.TabIndex = 12;
            btnAddToInventory.Text = "Add To Inventory";
            btnAddToInventory.UseVisualStyleBackColor = false;
            btnAddToInventory.Click += btnAddToInventory_Click;
            // 
            // btnRemoveFromInventory
            // 
            btnRemoveFromInventory.BackColor = SystemColors.HotTrack;
            btnRemoveFromInventory.ForeColor = SystemColors.ScrollBar;
            btnRemoveFromInventory.Location = new Point(55, 261);
            btnRemoveFromInventory.Margin = new Padding(2, 1, 2, 1);
            btnRemoveFromInventory.Name = "btnRemoveFromInventory";
            btnRemoveFromInventory.Size = new Size(97, 38);
            btnRemoveFromInventory.TabIndex = 13;
            btnRemoveFromInventory.Text = "Remove From Inventory";
            btnRemoveFromInventory.UseVisualStyleBackColor = false;
            btnRemoveFromInventory.Click += btnRemoveFromInventory_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(691, 321);
            Controls.Add(btnRemoveFromInventory);
            Controls.Add(btnAddToInventory);
            Controls.Add(label4);
            Controls.Add(tbxChangePrice);
            Controls.Add(lblPriceValue);
            Controls.Add(lblPrice);
            Controls.Add(label3);
            Controls.Add(tbxChangeInStock);
            Controls.Add(lblInStockValue);
            Controls.Add(lblInStock);
            Controls.Add(label2);
            Controls.Add(lBxInventory);
            Controls.Add(label1);
            Controls.Add(tBxAddProduct);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            FormClosed += AdminDashboard_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBxAddProduct;
        private Label label1;
        private ListBox lBxInventory;
        private Label label2;
        private Label lblInStock;
        private Label lblInStockValue;
        private TextBox tbxChangeInStock;
        private Label label3;
        private Label lblPrice;
        private Label lblPriceValue;
        private TextBox tbxChangePrice;
        private Label label4;
        private Button btnAddToInventory;
        private Button btnRemoveFromInventory;
    }
}