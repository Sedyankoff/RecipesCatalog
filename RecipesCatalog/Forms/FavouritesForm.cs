﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesCatalog.Forms
{
    public partial class FavouritesForm : Form
    {
        public FavouritesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenRecipeForm openRecipeForm = new OpenRecipeForm();
            openRecipeForm.BringToFront();
            openRecipeForm.Show();
        }

        private void btnRemoveFavourite_Click(object sender, EventArgs e)
        {
        }
    }
}
