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
    public partial class AppetizerForm : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        int editId;

        public AppetizerForm()
        {
            InitializeComponent();
            ResetSelect();
            UpdateGrid();
        }


        //Reset-ва Select-шъна в DataGrid-а
        private void ResetSelect()
        {
            dataAppetizer.ClearSelection();
            dataAppetizer.Enabled = true;
        }


        //Обновява DataGrid-а
        private void UpdateGrid()
        {
            dataAppetizer.DataSource = recipeBusiness.GetAllByType("Appetizer");
            dataAppetizer.ReadOnly = true;
            dataAppetizer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        //Бутон за премахване на рецепта от тип Appetizer
        private void btnRemoveAppetizer_Click(object sender, EventArgs e)
        {
            if (dataAppetizer.SelectedRows.Count > 0)
            {
                var item = dataAppetizer.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                recipeBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }


        //Бутон за добавяне на рецепта от тип Appetizer
        private void btnAddAppetizer_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm(1);
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }


        //Отваря информация за избраната рецепта от тип Appetizer
        private void btnOpenAppetizer_Click(object sender, EventArgs e)
        {
            if (dataAppetizer.SelectedRows.Count > 0)
            {
                OpenRecipeForm openRecipeForm = new OpenRecipeForm(GetInfo());
                openRecipeForm.BringToFront();
                openRecipeForm.Show();
            }
        }


        //Взима информация за избраната рецепта от тип Appetizer
        private Recipe GetInfo()
        {
            var item = dataAppetizer.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;
            Recipe selectedRecipe = recipeBusiness.Get(editId);
            return selectedRecipe;
        }


        //Добавя рецепта от тип Appetizer към "Favourite"
        private void btnAppetizerFavourite_Click(object sender, EventArgs e)
        {
            if (dataAppetizer.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = true;
                recipeBusiness.Update(recipe);
                btnAppetizerUnfavourite.Visible = true;
                btnAppetizerFavourite.Visible = false;
                UpdateGrid();
                ResetSelect();
            }  
        }


        //Маха рецептата от тип Appetizer от "Favourite"
        private void btnAppetizerUnfavourite_Click(object sender, EventArgs e)
        {
            if (dataAppetizer.SelectedRows.Count > 0)
            {
                Recipe recipe = GetInfo();
                recipe.IsFavourite = true;
                recipeBusiness.Update(recipe);
                btnAppetizerUnfavourite.Visible = false;
                btnAppetizerFavourite.Visible = true;
                UpdateGrid();
                ResetSelect();
            } 
        }


        //Промяна на бутона "Favourite" при избиране на рецепта
        private void dataAppetizer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Recipe selectedRecipe = GetInfo();
            if (selectedRecipe.IsFavourite)
            {
                btnAppetizerUnfavourite.Visible = true;
                btnAppetizerFavourite.Visible = false;
            }
            else
            {
                btnAppetizerUnfavourite.Visible = false;
                btnAppetizerFavourite.Visible = true;
            }
        }

        private void AppetizerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
