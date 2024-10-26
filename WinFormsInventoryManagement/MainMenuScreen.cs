﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInventoryManagement
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            // Hide Main Menu -> show product screen
            ProductsScreen productsScreen = new ProductsScreen();
            productsScreen.Show();
            this.Hide();
        }
    }
}
