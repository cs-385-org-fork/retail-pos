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
            btnAddItem.BackColor = SystemColors.ScrollBar;
            btnAddItem.ForeColor = SystemColors.MenuHighlight;
            btnAddItem.Location = new Point(1028, 533);
            btnAddItem.Margin = new Padding(7, 4, 7, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(450, 73);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lbxCheckoutItems
            // 
            lbxCheckoutItems.BackColor = SystemColors.ActiveCaption;
            lbxCheckoutItems.FormattingEnabled = true;
            lbxCheckoutItems.Location = new Point(22, 19);
            lbxCheckoutItems.Margin = new Padding(7, 4, 7, 4);
            lbxCheckoutItems.Name = "lbxCheckoutItems";
            lbxCheckoutItems.Size = new Size(989, 580);
            lbxCheckoutItems.TabIndex = 2;
            // 
            // tbxBarcode
            // 
            tbxBarcode.BackColor = SystemColors.InactiveCaption;
            tbxBarcode.Location = new Point(1028, 19);
            tbxBarcode.Margin = new Padding(7, 4, 7, 4);
            tbxBarcode.Name = "tbxBarcode";
            tbxBarcode.Size = new Size(446, 39);
            tbxBarcode.TabIndex = 3;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.BackColor = SystemColors.ScrollBar;
            btnCancelTransaction.ForeColor = SystemColors.MenuHighlight;
            btnCancelTransaction.Location = new Point(22, 610);
            btnCancelTransaction.Margin = new Padding(7, 4, 7, 4);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(345, 105);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.Text = "Cancel Transaction";
            btnCancelTransaction.UseVisualStyleBackColor = false;
            btnCancelTransaction.Click += btnCancelTransaction_Click;
            // 
            // btnFinishTransaction
            // 
            btnFinishTransaction.BackColor = SystemColors.MenuHighlight;
            btnFinishTransaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinishTransaction.ForeColor = SystemColors.InactiveCaption;
            btnFinishTransaction.Location = new Point(1028, 617);
            btnFinishTransaction.Margin = new Padding(7, 4, 7, 4);
            btnFinishTransaction.Name = "btnFinishTransaction";
            btnFinishTransaction.Size = new Size(450, 98);
            btnFinishTransaction.TabIndex = 5;
            btnFinishTransaction.Text = "Finish Transaction";
            btnFinishTransaction.UseVisualStyleBackColor = false;
            btnFinishTransaction.Click += btnFinishTransaction_Click;
            // 
            // lbxAllProducts
            // 
            lbxAllProducts.BackColor = SystemColors.ActiveCaption;
            lbxAllProducts.FormattingEnabled = true;
            lbxAllProducts.Location = new Point(1028, 73);
            lbxAllProducts.Margin = new Padding(7, 4, 7, 4);
            lbxAllProducts.Name = "lbxAllProducts";
            lbxAllProducts.Size = new Size(446, 388);
            lbxAllProducts.TabIndex = 6;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(555, 681);
            lblClock.Margin = new Padding(7, 0, 7, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(278, 32);
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
            numQuantity.Location = new Point(1028, 474);
            numQuantity.Margin = new Padding(7, 6, 7, 6);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(450, 39);
            numQuantity.TabIndex = 8;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // lblTotals
            // 
            lblTotals.AutoSize = true;
            lblTotals.Location = new Point(433, 617);
            lblTotals.Margin = new Padding(7, 0, 7, 0);
            lblTotals.Name = "lblTotals";
            lblTotals.Size = new Size(537, 32);
            lblTotals.TabIndex = 9;
            lblTotals.Text = "Subtotal: 00.00      Tax: 00.00      Total: 00.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1500, 721);
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
