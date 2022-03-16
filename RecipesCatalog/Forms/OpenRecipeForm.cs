using RecipesCatalog.Data.Models;
using System;
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
    public partial class OpenRecipeForm : Form
    {
        public OpenRecipeForm()
        {
            InitializeComponent();
        }
        public OpenRecipeForm(Recipe recipe)
        {
            InitializeComponent();
            txtOpenName.Text = recipe.Name;
            txtOpenType.Text = recipe.Type;
            txtOpenPreparation.Text = recipe.Preparation;

            foreach (var product in recipe.Products)
            {
                txtOpenProducts.Text += product;
            }
        }

        private void OpenRecipeForm_Load(object sender, EventArgs e)
        {

        }

        private void txtOpenType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
