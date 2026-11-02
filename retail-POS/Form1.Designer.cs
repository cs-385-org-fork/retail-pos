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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            btnCancelTransaction = new Button();
            btnFinishTransaction = new Button();
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(548, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 284);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(12, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(530, 364);
            listBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(548, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 3;
            // 
            // btnCancelTransaction
            // 
            btnCancelTransaction.Location = new Point(12, 382);
            btnCancelTransaction.Name = "btnCancelTransaction";
            btnCancelTransaction.Size = new Size(184, 65);
            btnCancelTransaction.TabIndex = 4;
            btnCancelTransaction.Text = "Cancel Transaction";
            btnCancelTransaction.UseVisualStyleBackColor = true;
            // 
            // btnFinishTransaction
            // 
            btnFinishTransaction.Location = new Point(548, 385);
            btnFinishTransaction.Name = "btnFinishTransaction";
            btnFinishTransaction.Size = new Size(240, 62);
            btnFinishTransaction.TabIndex = 5;
            btnFinishTransaction.Text = "Finish Transaction";
            btnFinishTransaction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinishTransaction);
            Controls.Add(btnCancelTransaction);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnAddItem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddItem;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private Button btnCancelTransaction;
        private Button btnFinishTransaction;
    }
}
