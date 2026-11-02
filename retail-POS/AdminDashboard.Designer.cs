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
        private void InitializeComponent()
        {
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
            tBxAddProduct.Location = new Point(103, 108);
            tBxAddProduct.Name = "tBxAddProduct";
            tBxAddProduct.Size = new Size(304, 39);
            tBxAddProduct.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(103, 50);
            label1.Name = "label1";
            label1.Size = new Size(304, 35);
            label1.TabIndex = 1;
            label1.Text = "Enter Product Name";
            // 
            // lBxInventory
            // 
            lBxInventory.BackColor = SystemColors.InactiveCaption;
            lBxInventory.ForeColor = SystemColors.ActiveCaptionText;
            lBxInventory.FormattingEnabled = true;
            lBxInventory.Location = new Point(103, 278);
            lBxInventory.Name = "lBxInventory";
            lBxInventory.Size = new Size(304, 260);
            lBxInventory.TabIndex = 2;
            lBxInventory.SelectedIndexChanged += lBxInventory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 224);
            label2.Name = "label2";
            label2.Size = new Size(274, 35);
            label2.TabIndex = 3;
            label2.Text = "Current Inventory";
            // 
            // lblInStock
            // 
            lblInStock.AutoSize = true;
            lblInStock.Location = new Point(427, 278);
            lblInStock.Name = "lblInStock";
            lblInStock.Size = new Size(196, 32);
            lblInStock.TabIndex = 4;
            lblInStock.Text = "Amount In Stock:";
            // 
            // lblInStockValue
            // 
            lblInStockValue.AutoSize = true;
            lblInStockValue.Location = new Point(629, 278);
            lblInStockValue.Name = "lblInStockValue";
            lblInStockValue.Size = new Size(53, 32);
            lblInStockValue.TabIndex = 5;
            lblInStockValue.Text = "000";
            // 
            // tbxChangeInStock
            // 
            tbxChangeInStock.BackColor = SystemColors.InactiveCaption;
            tbxChangeInStock.Location = new Point(427, 354);
            tbxChangeInStock.Name = "tbxChangeInStock";
            tbxChangeInStock.Size = new Size(280, 39);
            tbxChangeInStock.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 319);
            label3.Name = "label3";
            label3.Size = new Size(280, 32);
            label3.TabIndex = 7;
            label3.Text = "Change Amount In Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(427, 422);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(77, 32);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price: ";
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.Location = new Point(510, 422);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(53, 32);
            lblPriceValue.TabIndex = 9;
            lblPriceValue.Text = "000";
            // 
            // tbxChangePrice
            // 
            tbxChangePrice.BackColor = SystemColors.InactiveCaption;
            tbxChangePrice.Location = new Point(427, 489);
            tbxChangePrice.Name = "tbxChangePrice";
            tbxChangePrice.Size = new Size(200, 39);
            tbxChangePrice.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 454);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 11;
            label4.Text = "Change Price";
            // 
            // btnAddToInventory
            // 
            btnAddToInventory.BackColor = SystemColors.ScrollBar;
            btnAddToInventory.ForeColor = SystemColors.HotTrack;
            btnAddToInventory.Location = new Point(455, 104);
            btnAddToInventory.Name = "btnAddToInventory";
            btnAddToInventory.Size = new Size(146, 82);
            btnAddToInventory.TabIndex = 12;
            btnAddToInventory.Text = "Add To Inventory";
            btnAddToInventory.UseVisualStyleBackColor = false;
            // 
            // btnRemoveFromInventory
            // 
            btnRemoveFromInventory.BackColor = SystemColors.HotTrack;
            btnRemoveFromInventory.ForeColor = SystemColors.ScrollBar;
            btnRemoveFromInventory.Location = new Point(629, 104);
            btnRemoveFromInventory.Name = "btnRemoveFromInventory";
            btnRemoveFromInventory.Size = new Size(180, 82);
            btnRemoveFromInventory.TabIndex = 13;
            btnRemoveFromInventory.Text = "Remove From Inventory";
            btnRemoveFromInventory.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1436, 720);
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
            Name = "AdminDashboard";
            Text = "AdminDashboard";
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