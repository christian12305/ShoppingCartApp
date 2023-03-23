/*
 * File: PrintBooksForm.cs
 * Author: Christian J. Ramos Ortega 841-18-4582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/22/2023
 * Purpose: This form creates a list of available print books
 *          for the user to choose and add to the cart.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCartApp
{
    public partial class PrintBooksForm : Form
    {
        string? output = null;

        public PrintBooksForm()
        {
            InitializeComponent();
        }

        //Event handler for the add to cart button
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        //Stores the chosen print books to the Tag property.
        private void SaveData()
        {
            output += $"{lstPrintBooks.SelectedItem.ToString()},\n";
            this.Tag = output;
        }

        //Adds the corresponding list to the form load event handler
        private void PrintBooksForm_Load(object sender, EventArgs e)
        {
            lstPrintBooks.Items.Add("C# Programming Made Easy - $11.95");
            lstPrintBooks.Items.Add("Feel the Stress - $18.50");
            lstPrintBooks.Items.Add("Learn Calculus in One Day - $29.95");
            lstPrintBooks.Items.Add("The History of Computers - $14.50");
        }

        //Event handler for the close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
