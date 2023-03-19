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
        public PrintBooksForm()
        {
            InitializeComponent();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            
        }

        private void PrintBooksForm_Load(object sender, EventArgs e)
        {
            lstPrintBooks.Items.Add(@"C# Programming Made Easy - $11.95");
            lstPrintBooks.Items.Add(@"Feel the stress - $18.50");
            lstPrintBooks.Items.Add(@"Learn Calculus in One Day - $29.95");
            lstPrintBooks.Items.Add(@"The History of Computers - $14.50");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
