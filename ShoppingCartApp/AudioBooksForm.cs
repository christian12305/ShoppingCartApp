﻿/*
 * File: AudioBooksForm.cs
 * Author: Christian J. Ramos Ortega 841-18-4582
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/22/2023
 * Purpose: This form creates a list of available audio books
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
    public partial class AudioBooksForm : Form
    {
        public AudioBooksForm()
        {
            InitializeComponent();
        }

        //Adds the corresponding list to the form load event handler
        private void lstAudioBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAudioBooks.Items.Add(@"Developing People Skills - $12.95");
            lstAudioBooks.Items.Add(@"Indiscrete Math - $19.95");
            lstAudioBooks.Items.Add(@"Relaxation Techniques - $11.50");
            lstAudioBooks.Items.Add(@"You can Program Too! - $25.50");
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {

        }  
        
        //Event handler for the close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
