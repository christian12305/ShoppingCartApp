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
        SortedDictionary<string,decimal> cartSelection = new SortedDictionary<string,decimal>();
        public ShoppingCartForm()
        {
            InitializeComponent();
        }

        //Button event handler for removing an item.
        private void btnRemove_Click(object sender, EventArgs e)
        {

            if(lstProducts.Items.Count != 0) 
            {
                string? item = lstProducts.SelectedItem.ToString();

                FormatProduct(item, out string name, out decimal price);

                lstProducts.Items.Remove(item);

                cartSelection.Remove(name);

                MessageBox.Show($"Item: {name} has been removed from the cart!", "Removed from Cart", MessageBoxButtons.OK);

                UpdateTotals();
            }

        }

        //Open the Print Books Form as a modal form.
        private void mnuProducts_PrintBooks_Click(object sender, EventArgs e)
        {
            Form printBooks = new PrintBooksForm();

            DialogResult printBooKResult = printBooks.ShowDialog();

            ReadTag(printBooks, printBooKResult);
        }

        //Receives the data from the printBooks form and manipulates for the correct format
        private void ReadTag(Form printBooks, DialogResult printBooKResult)
        {
            if (printBooKResult == DialogResult.OK)
            {
                string? tagString = printBooks.Tag.ToString();

                String[] tagSplit = tagString.Split(",");

                //Adding each selected item to our products list and our dictionary
                // if it has not been added before.
                foreach (String str in tagSplit)
                {
                    if (!lstProducts.Items.Contains(str))
                    {
                        lstProducts.Items.Add(str);

                        FormatProduct(str, out string name, out decimal price);

                        cartSelection.Add(name, price);

                        UpdateTotals();
                    }  
                }

            }
        }

        //Updates the totals for each textbox.
        private void UpdateTotals()
        {
            SubtotalCalc(out decimal subtotal);

            txtSubtotal.Text = subtotal.ToString("c");

            TaxCalc(subtotal, out decimal tax);

            txtTax.Text = tax.ToString("c");

            ShippingCalc(out decimal shipping);

            txtShipping.Text = shipping.ToString("c");

            TotalCalc(subtotal, tax, shipping, out decimal total);

            txtTotal.Text = total.ToString("c");

        }

        //Calculates the total amount for the items in the cart.
        private void TotalCalc(decimal subtotal, decimal tax, decimal shipping, out decimal total) => total = subtotal + tax + shipping;

        //Calculates shipping for all the items selected.
        private void ShippingCalc(out decimal shipping) => shipping = cartSelection.Count * 2.0m;
        

        //Calculates the 11.5% tax with the calculated subtotal
        private void TaxCalc(decimal subtotal, out decimal tax) => tax = subtotal * 0.115m;

        //Calculate Subtotal
        private void SubtotalCalc(out decimal subtotal)
        {
            subtotal = 0m;

            foreach (var item in cartSelection)
                subtotal += item.Value;
        }

        //Formats the products key and values to add
        private static void FormatProduct(string str, out string name, out decimal price)
        {
            string[] bookSplit = str.Split("-");

            name = bookSplit[0].ToString();

            string temp = bookSplit[1].Replace("$", "").Trim();

            price = decimal.Parse(temp);
        }

        //Open the Audio Books Form as a modal form.
        private void mnuProducts_AudioBooks_Click(object sender, EventArgs e)
        {
            Form audioBooks = new AudioBooksForm();

            DialogResult audioBookResult = audioBooks.ShowDialog();

            ReadTag(audioBooks, audioBookResult);
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