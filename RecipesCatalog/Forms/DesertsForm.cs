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
    public partial class DesertsForm : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        int editId;

        public DesertsForm()
        {
            InitializeComponent();
            ResetSelect();
            UpdateGrid();
        }


        
        private void ResetSelect()
        {
            dataDeserts.ClearSelection();
            dataDeserts.Enabled = true;
        }
        private void UpdateGrid()
        {
            dataDeserts.DataSource = recipeBusiness.GetAllByType("Desert");
            dataDeserts.ReadOnly = true;
            dataDeserts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnAddDesert_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm(3);
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }
       
        private void btnRemoveDesert_Click_1(object sender, EventArgs e)
        {
            if (dataDeserts.SelectedRows.Count > 0)
            {
                var item = dataDeserts.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                recipeBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void btnOpenDesert_Click(object sender, EventArgs e)
        {
            if (dataDeserts.SelectedRows.Count > 0)
            {
                OpenRecipeForm openRecipeForm = new OpenRecipeForm(GetInfo());
                openRecipeForm.BringToFront();
                openRecipeForm.Show();
            }
        }

        private Recipe GetInfo()
        {
            var item = dataDeserts.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;
            Recipe selectedRecipe = recipeBusiness.Get(editId);
            return selectedRecipe;
        }

        private void btnDesertUnfavourite_Click(object sender, EventArgs e)
        {
            if (dataDeserts.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = false;
                recipeBusiness.Update(recipe);
                btnDesertUnfavourite.Visible = false;
                btnDesertFavourite.Visible = true;
                UpdateGrid();
                ResetSelect();
            }
        }

        private void btnDesertFavourite_Click(object sender, EventArgs e)
        {
            if (dataDeserts.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = true;
                recipeBusiness.Update(recipe);
                btnDesertUnfavourite.Visible = true;
                btnDesertFavourite.Visible = false;
                UpdateGrid();
                ResetSelect();
            }
        }

        private void dataDeserts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Recipe selectedRecipe = GetInfo();
            if (selectedRecipe.IsFavourite)
            {
                btnDesertUnfavourite.Visible = true;
                btnDesertFavourite.Visible = false;
            }
            else
            {
                btnDesertUnfavourite.Visible = false;
                btnDesertFavourite.Visible = true;
            }
        }
    }
}