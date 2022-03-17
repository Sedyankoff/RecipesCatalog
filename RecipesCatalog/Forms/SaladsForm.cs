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
    public partial class SaladsForm : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        int editId;
        public SaladsForm()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void ResetSelect()
        {
            dataSalads.ClearSelection();
            dataSalads.Enabled = true;
        }

        private void UpdateGrid()
        {
            dataSalads.DataSource = recipeBusiness.GetAllByType("Salad");
            dataSalads.ReadOnly = true;
            dataSalads.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnRemoveSalad_Click_1(object sender, EventArgs e)
        {
            if (dataSalads.SelectedRows.Count > 0)
            {
                var item = dataSalads.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                recipeBusiness.Delete(id);
                UpdateGrid();
                btnSaladUnfavourite.Visible = false;
                btnSaladFavourite.Visible = true;
                ResetSelect();
            }
        }

        private void btnAddSalad_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm(0);
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }

        private void btnOpenSalad_Click(object sender, EventArgs e)
        {
            if (dataSalads.SelectedRows.Count > 0)
            {
                OpenRecipeForm openRecipeForm = new OpenRecipeForm(GetInfo());
                openRecipeForm.BringToFront();
                openRecipeForm.Show();
            }
        }
        private Recipe GetInfo()
        {
            var item = dataSalads.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;

            Recipe selectedRecipe = recipeBusiness.Get(editId);
            return selectedRecipe;
        }

        private void btnSaladFavourite_Click(object sender, EventArgs e)
        {
            if (dataSalads.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = true;
                recipeBusiness.Update(recipe);
                btnSaladUnfavourite.Visible = true;
                btnSaladFavourite.Visible=false;
                UpdateGrid();
                ResetSelect();
            }  
        }

        private void btnSaladUnfavourite_Click(object sender, EventArgs e)
        {
            if (dataSalads.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = false;
                recipeBusiness.Update(recipe);
                btnSaladUnfavourite.Visible = false;
                btnSaladFavourite.Visible = true;
                UpdateGrid();
                ResetSelect();
            }   
        }

        private void dataSalads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Recipe selectedRecipe = GetInfo();
            if (selectedRecipe.IsFavourite)
            {
                btnSaladUnfavourite.Visible = true;
                btnSaladFavourite.Visible = false;
            }
            else
            {
                btnSaladUnfavourite.Visible = false;
                btnSaladFavourite.Visible = true;
            }
        }

        private void SaladsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
