namespace ShoppingCartApp
{
    partial class PrintBooksForm
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
            this.grpPrintBooks = new System.Windows.Forms.GroupBox();
            this.lstPrintBooks = new System.Windows.Forms.ListBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPrintBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrintBooks
            // 
            this.grpPrintBooks.Controls.Add(this.lstPrintBooks);
            this.grpPrintBooks.Location = new System.Drawing.Point(12, 12);
            this.grpPrintBooks.Name = "grpPrintBooks";
            this.grpPrintBooks.Size = new System.Drawing.Size(318, 146);
            this.grpPrintBooks.TabIndex = 0;
            this.grpPrintBooks.TabStop = false;
            this.grpPrintBooks.Text = "Select a Print Book";
            // 
            // lstPrintBooks
            // 
            this.lstPrintBooks.FormattingEnabled = true;
            this.lstPrintBooks.ItemHeight = 15;
            this.lstPrintBooks.Location = new System.Drawing.Point(20, 22);
            this.lstPrintBooks.Name = "lstPrintBooks";
            this.lstPrintBooks.Size = new System.Drawing.Size(292, 109);
            this.lstPrintBooks.TabIndex = 0;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(161, 180);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(78, 23);
            this.btnAddCart.TabIndex = 1;
            this.btnAddCart.Text = "&Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PrintBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(344, 214);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.grpPrintBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Books";
            this.Load += new System.EventHandler(this.PrintBooksForm_Load);
            this.grpPrintBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpPrintBooks;
        private ListBox lstPrintBooks;
        private Button btnAddCart;
        private Button btnClose;


    }
}