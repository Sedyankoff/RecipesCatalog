using RecipesCatalog.Business;
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
    public partial class FavouritesForm : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        int editId;

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
            if (dataFavourites.SelectedRows.Count > 0)
            {
                OpenRecipeForm openRecipeForm = new OpenRecipeForm(GetInfo());
                openRecipeForm.BringToFront();
                openRecipeForm.Show();
            }
        }

        private void btnRemoveFavourite_Click(object sender, EventArgs e)
        {
            if (dataFavourites.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = false;
                recipeBusiness.Update(recipe);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void ResetSelect()
        {
            dataFavourites.ClearSelection();
            dataFavourites.Enabled = true;
        }
        private Recipe GetInfo()
        {
            var item = dataFavourites.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;
            Recipe selectedRecipe = recipeBusiness.Get(editId);
            return selectedRecipe;
        }
    }
}
