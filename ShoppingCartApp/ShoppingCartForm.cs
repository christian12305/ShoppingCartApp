namespace ShoppingCartApp
{
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {

        }

        //Button event handler for removing an item.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstProducts.ClearSelected();
        }

        //Open the Print Books Form as a modal form.
        private void mnuProducts_PrintBooks_Click(object sender, EventArgs e)
        {
            new PrintBooksForm().ShowDialog();
        }

        //Open the Audio Books Form as a modal form.
        private void mnuProducts_AudioBooks_Click(object sender, EventArgs e)
        {
            new AudioBooksForm().ShowDialog();
        }

        //Event handler for the About button
        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            string output = "Shopping Cart App. \n" +
                            "Author: Christian Ramos 2023.\n" +
                            "This application serves as a shopping cart\n" +
                            "for a book selling company.";

            MessageBox.Show(output, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Event Handler for the reset button.
        private void mnuFile_Reset_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
            txtShipping.Clear();
            txtTotal.Clear();
        }

        //Event handler for the Exit button.
        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}