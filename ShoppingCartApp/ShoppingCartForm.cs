/*
 * File: ShoppingCartForm.cs
 * Author: Christian J. Ramos Ortega 841-18-4582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/22/2023
 * Purpose: This form creates a shopping cart for the user.
 *          The user may select books from print books and audio books
 *          to add to their shopping cart and calculate total.
 */
namespace ShoppingCartApp
{
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
        }

        //Button event handler for removing an item.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Remove(lstProducts.SelectedItem);
        }

        //Open the Print Books Form as a modal form.
        private void mnuProducts_PrintBooks_Click(object sender, EventArgs e)
        {
            Form printBooks = new PrintBooksForm();
            DialogResult printBooKResult = printBooks.ShowDialog();

            if(printBooKResult == DialogResult.OK)
            {
                String[] splitArray = printBooks.Tag.ToString().Split(",");
                foreach( String s in splitArray)
                {
                    lstProducts.Items.Add(s);
                }
                             
            }
        }

        //Open the Audio Books Form as a modal form.
        private void mnuProducts_AudioBooks_Click(object sender, EventArgs e)
        {
            Form audioBooks = new AudioBooksForm();
            DialogResult aBookResult = audioBooks.ShowDialog();
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