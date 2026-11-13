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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            btnAddItem = new Button();
            lbxCheckoutItems = new ListBox();
            tbxBarcode = new TextBox();
            btnCancelTransaction = new Button();
            btnFinishTransaction = new Button();
            lbxAllProducts = new ListBox();
            lblClock = new Label();
            clockTimer = new System.Windows.Forms.Timer(components);
            numQuantity = new NumericUpDown();
            lblTotals = new Label();
            lblQuantity = new Label();
            btnRemoveItem = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = SystemColors.ScrollBar;
            btnAddItem.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnAddItem.ForeColor = SystemColors.MenuHighlight;
            btnAddItem.Location = new Point(585, 444);
            btnAddItem.Margin = new Padding(7, 4, 7, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(284, 45);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lbxCheckoutItems
            // 
            lbxCheckoutItems.BackColor = SystemColors.ActiveCaption;
            lbxCheckoutItems.FormattingEnabled = true;
            lbxCheckoutItems.Location = new Point(16, 13);
            lbxCheckoutItems.Margin = new Padding(7, 4, 7, 4);
            lbxCheckoutItems.Name = "lbxCheckoutItems";
            lbxCheckoutItems.Size = new Size(555, 529);
            lbxCheckoutItems.TabIndex = 2;
            // 
            // tbxBarcode
            // 
            tbxBarcode.BackColor = SystemColors.InactiveCaption;
            tbxBarcode.Location = new Point(585, 13);
            tbxBarcode.Margin = new Padding(7, 4, 7, 4);
            tbxBarcode.Name = "tbxBarcode";
            tbxBarcode.PlaceholderText = "Enter Barcode/Product ID";
            tbxBarcode.Size = new Size(284, 24);
            tbxBarcode.TabIndex = 3;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.BackColor = SystemColors.ScrollBar;
            btnCancelTransaction.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnCancelTransaction.ForeColor = SystemColors.MenuHighlight;
            btnCancelTransaction.Location = new Point(16, 550);
            btnCancelTransaction.Margin = new Padding(7, 4, 7, 4);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(250, 99);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.Text = "Cancel Transaction";
            btnCancelTransaction.UseVisualStyleBackColor = false;
            btnCancelTransaction.Click += btnCancelTransaction_Click;
            // 
            // btnFinishTransaction
            // 
            btnFinishTransaction.BackColor = SystemColors.MenuHighlight;
            btnFinishTransaction.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnFinishTransaction.ForeColor = SystemColors.InactiveCaption;
            btnFinishTransaction.Location = new Point(585, 550);
            btnFinishTransaction.Margin = new Padding(7, 4, 7, 4);
            btnFinishTransaction.Name = "btnFinishTransaction";
            btnFinishTransaction.Size = new Size(284, 98);
            btnFinishTransaction.TabIndex = 5;
            btnFinishTransaction.Text = "Finish Transaction";
            btnFinishTransaction.UseVisualStyleBackColor = false;
            btnFinishTransaction.Click += btnFinishTransaction_Click;
            // 
            // lbxAllProducts
            // 
            lbxAllProducts.BackColor = SystemColors.ActiveCaption;
            lbxAllProducts.FormattingEnabled = true;
            lbxAllProducts.Location = new Point(585, 45);
            lbxAllProducts.Margin = new Padding(7, 4, 7, 4);
            lbxAllProducts.Name = "lbxAllProducts";
            lbxAllProducts.Size = new Size(284, 349);
            lbxAllProducts.TabIndex = 6;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            lblClock.Location = new Point(379, 628);
            lblClock.Margin = new Padding(7, 0, 7, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(192, 21);
            lblClock.TabIndex = 7;
            lblClock.Text = "00:00:00 AM 00/00/00";
            lblClock.Click += lblClock_Click;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = SystemColors.InactiveCaption;
            numQuantity.Location = new Point(693, 410);
            numQuantity.Margin = new Padding(7, 6, 7, 6);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(176, 24);
            numQuantity.TabIndex = 8;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // lblTotals
            // 
            lblTotals.AutoSize = true;
            lblTotals.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lblTotals.Location = new Point(280, 550);
            lblTotals.Margin = new Padding(7, 0, 7, 0);
            lblTotals.Name = "lblTotals";
            lblTotals.Size = new Size(164, 75);
            lblTotals.TabIndex = 9;
            lblTotals.Text = "Subtotal: $00.00\r\nTax: $00.00\r\nTotal: $00.00";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(585, 412);
            lblQuantity.Margin = new Padding(7, 0, 7, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(94, 15);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Item Quantity:";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = SystemColors.ScrollBar;
            btnRemoveItem.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnRemoveItem.ForeColor = Color.Crimson;
            btnRemoveItem.Location = new Point(585, 497);
            btnRemoveItem.Margin = new Padding(7, 4, 7, 4);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(284, 45);
            btnRemoveItem.TabIndex = 11;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(884, 661);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblQuantity);
            Controls.Add(lblTotals);
            Controls.Add(numQuantity);
            Controls.Add(lblClock);
            Controls.Add(lbxAllProducts);
            Controls.Add(btnFinishTransaction);
            Controls.Add(btnCancelTransaction);
            Controls.Add(tbxBarcode);
            Controls.Add(lbxCheckoutItems);
            Controls.Add(btnAddItem);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 4, 7, 4);
            Name = "Form1";
            Text = "Point Of Sale System";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
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
        private Label lblClock;
        private System.Windows.Forms.Timer clockTimer;
        private NumericUpDown numQuantity;
        private Label lblTotals;
        private Label lblQuantity;
        private Button btnRemoveItem;
    }
}
