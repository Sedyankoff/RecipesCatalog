using RecipesCatalog.Business;
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
    public partial class FavouritesForm : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        public FavouritesForm()
        {
            InitializeComponent();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            dataFavourites.DataSource = recipeBusiness.GetAllFavourites();
            dataFavourites.ReadOnly = true;
            dataFavourites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
