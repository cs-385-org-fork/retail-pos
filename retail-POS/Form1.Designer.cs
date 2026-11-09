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
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(480, 250);
            btnAddItem.Margin = new Padding(3, 2, 3, 2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(210, 34);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lbxCheckoutItems
            // 
            lbxCheckoutItems.FormattingEnabled = true;
            lbxCheckoutItems.Location = new Point(10, 9);
            lbxCheckoutItems.Margin = new Padding(3, 2, 3, 2);
            lbxCheckoutItems.Name = "lbxCheckoutItems";
            lbxCheckoutItems.Size = new Size(464, 274);
            lbxCheckoutItems.TabIndex = 2;
            // 
            // tbxBarcode
            // 
            tbxBarcode.Location = new Point(480, 9);
            tbxBarcode.Margin = new Padding(3, 2, 3, 2);
            tbxBarcode.Name = "tbxBarcode";
            tbxBarcode.Size = new Size(210, 23);
            tbxBarcode.TabIndex = 3;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.Location = new Point(10, 286);
            btnCancelTransaction.Margin = new Padding(3, 2, 3, 2);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(161, 49);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.Text = "Cancel Transaction";
            btnCancelTransaction.UseVisualStyleBackColor = true;
            btnCancelTransaction.Click += btnCancelTransaction_Click;
            // 
            // btnFinishTransaction
            // 
            btnFinishTransaction.Location = new Point(480, 289);
            btnFinishTransaction.Margin = new Padding(3, 2, 3, 2);
            btnFinishTransaction.Name = "btnFinishTransaction";
            btnFinishTransaction.Size = new Size(210, 46);
            btnFinishTransaction.TabIndex = 5;
            btnFinishTransaction.Text = "Finish Transaction";
            btnFinishTransaction.UseVisualStyleBackColor = true;
            btnFinishTransaction.Click += btnFinishTransaction_Click;
            // 
            // lbxAllProducts
            // 
            lbxAllProducts.FormattingEnabled = true;
            lbxAllProducts.Location = new Point(480, 34);
            lbxAllProducts.Margin = new Padding(3, 2, 3, 2);
            lbxAllProducts.Name = "lbxAllProducts";
            lbxAllProducts.Size = new Size(210, 184);
            lbxAllProducts.TabIndex = 6;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(259, 319);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(120, 15);
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
            numQuantity.Location = new Point(480, 222);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(210, 23);
            numQuantity.TabIndex = 8;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // lblTotals
            // 
            lblTotals.AutoSize = true;
            lblTotals.Location = new Point(202, 289);
            lblTotals.Name = "lblTotals";
            lblTotals.Size = new Size(229, 15);
            lblTotals.TabIndex = 9;
            lblTotals.Text = "Subtotal: 00.00      Tax: 00.00      Total: 00.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblTotals);
            Controls.Add(numQuantity);
            Controls.Add(lblClock);
            Controls.Add(lbxAllProducts);
            Controls.Add(btnFinishTransaction);
            Controls.Add(btnCancelTransaction);
            Controls.Add(tbxBarcode);
            Controls.Add(lbxCheckoutItems);
            Controls.Add(btnAddItem);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
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
    }
}
