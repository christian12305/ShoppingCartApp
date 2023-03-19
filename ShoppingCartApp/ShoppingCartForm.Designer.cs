namespace ShoppingCartApp
{
    partial class ShoppingCartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducts_PrintBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProducts_AudioBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProductSelected = new System.Windows.Forms.GroupBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpProductSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuProducts,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Reset,
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_Reset
            // 
            this.mnuFile_Reset.Name = "mnuFile_Reset";
            this.mnuFile_Reset.Size = new System.Drawing.Size(180, 22);
            this.mnuFile_Reset.Text = "R&eset";
            this.mnuFile_Reset.Click += new System.EventHandler(this.mnuFile_Reset_Click);
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Size = new System.Drawing.Size(180, 22);
            this.mnuFile_Exit.Text = "E&xit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuProducts
            // 
            this.mnuProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProducts_PrintBooks,
            this.mnuProducts_AudioBooks});
            this.mnuProducts.Name = "mnuProducts";
            this.mnuProducts.Size = new System.Drawing.Size(66, 20);
            this.mnuProducts.Text = "Products";
            // 
            // mnuProducts_PrintBooks
            // 
            this.mnuProducts_PrintBooks.Name = "mnuProducts_PrintBooks";
            this.mnuProducts_PrintBooks.Size = new System.Drawing.Size(141, 22);
            this.mnuProducts_PrintBooks.Text = "P&rint Books";
            this.mnuProducts_PrintBooks.Click += new System.EventHandler(this.mnuProducts_PrintBooks_Click);
            // 
            // mnuProducts_AudioBooks
            // 
            this.mnuProducts_AudioBooks.Name = "mnuProducts_AudioBooks";
            this.mnuProducts_AudioBooks.Size = new System.Drawing.Size(141, 22);
            this.mnuProducts_AudioBooks.Text = "A&udio Books";
            this.mnuProducts_AudioBooks.Click += new System.EventHandler(this.mnuProducts_AudioBooks_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(107, 22);
            this.mnuHelp_About.Text = "&About";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // grpProductSelected
            // 
            this.grpProductSelected.Controls.Add(this.lstProducts);
            this.grpProductSelected.Location = new System.Drawing.Point(12, 39);
            this.grpProductSelected.Name = "grpProductSelected";
            this.grpProductSelected.Size = new System.Drawing.Size(245, 155);
            this.grpProductSelected.TabIndex = 1;
            this.grpProductSelected.TabStop = false;
            this.grpProductSelected.Text = "Products Selected";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(6, 22);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(233, 124);
            this.lstProducts.TabIndex = 0;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(273, 52);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 15);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(344, 44);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(273, 82);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(27, 15);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(344, 79);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 5;
            this.txtTax.TabStop = false;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(273, 118);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(57, 15);
            this.lblShipping.TabIndex = 6;
            this.lblShipping.Text = "Shipping:";
            this.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(344, 115);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.ReadOnly = true;
            this.txtShipping.Size = new System.Drawing.Size(100, 23);
            this.txtShipping.TabIndex = 7;
            this.txtShipping.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(273, 154);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(344, 151);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(138, 215);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 250);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grpProductSelected);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.ShoppingCartForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProductSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFile_Exit;
        private ToolStripMenuItem mnuProducts;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuHelp_About;
        private GroupBox grpProductSelected;
        private ToolStripMenuItem mnuFile_Reset;
        private ToolStripMenuItem mnuProducts_PrintBooks;
        private ToolStripMenuItem mnuProducts_AudioBooks;
        private ListBox lstProducts;
        private Label lblSubtotal;
        private TextBox txtSubtotal;
        private Label lblTax;
        private TextBox txtTax;
        private Label lblShipping;
        private TextBox txtShipping;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnRemove;
    }
}