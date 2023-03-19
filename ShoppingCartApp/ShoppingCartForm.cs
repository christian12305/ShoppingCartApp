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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstProducts.ClearSelected();
        }

        private void mnuProducts_PrintBooks_Click(object sender, EventArgs e)
        {
            new PrintBooksForm().ShowDialog();
        }

        private void mnuProducts_AudioBooks_Click(object sender, EventArgs e)
        {
            new AudioBooksForm().ShowDialog();
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            string output = "Shopping Cart App. \n" +
                            "Author: Christian Ramos 2023.\n" +
                            "This application serves as a shopping cart\n" +
                            "for a book selling company.";

            MessageBox.Show(output, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuFile_Reset_Click(object sender, EventArgs e)
        {
            //ClearSelected() is not the method I need. FIX THIS
            lstProducts.ClearSelected();
            txtSubtotal.Clear();
            txtTax.Clear();
            txtShipping.Clear();
            txtTotal.Clear();
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}