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
    public partial class MainCoursesForm : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        int editId;

        public MainCoursesForm()
        {
            InitializeComponent();
            UpdateGrid();
            ResetSelect();

        }
        private void DisableSelect()
        {
            dataMainCourses.Enabled = false;
        }

        private void ResetSelect()
        {
            dataMainCourses.ClearSelection();
            dataMainCourses.Enabled = true;
        }

        private void UpdateGrid()
        {
            dataMainCourses.DataSource = recipeBusiness.GetAllByType("Main Course");
            dataMainCourses.ReadOnly = true;
            dataMainCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAddMainCourses_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm(2);
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }

        private void btnRemoveMainCourses_Click_1(object sender, EventArgs e)
        {
            if (dataMainCourses.SelectedRows.Count > 0)
            {
                var item = dataMainCourses.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                recipeBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void btnOpenMainCourses_Click(object sender, EventArgs e)
        {
            if (dataMainCourses.SelectedRows.Count > 0)
            {
                OpenRecipeForm openRecipeForm = new OpenRecipeForm(GetInfo());
                openRecipeForm.BringToFront();
                openRecipeForm.Show();
            }
        }

        private Recipe GetInfo()
        {
            var item = dataMainCourses.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            editId = id;

            Recipe selectedRecipe = recipeBusiness.Get(editId);
            return selectedRecipe;
        }

        private void btnMainCoursesFavourite_Click(object sender, EventArgs e)
        {
            Recipe recipe = GetInfo();
            recipe.IsFavourite = true;
            recipeBusiness.Update(recipe);
            btnMainCoursesFavourite.Visible = false;
            btnMainCoursesUnfavourite.Visible = true;
            UpdateGrid();
            ResetSelect();
        }

        private void btnMainCoursesUnfavourite_Click(object sender, EventArgs e)
        {
            Recipe recipe = GetInfo();
            recipe.IsFavourite = false;
            recipeBusiness.Update(recipe);
            btnMainCoursesFavourite.Visible = true;
            btnMainCoursesUnfavourite.Visible = false;
            UpdateGrid();
            ResetSelect();
        }

        private void dataMainCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Recipe selectedRecipe = GetInfo();
            if (selectedRecipe.IsFavourite)
            {
                btnMainCoursesUnfavourite.Visible = true;
                btnMainCoursesFavourite.Visible = false;
            }
            else
            {
                btnMainCoursesUnfavourite.Visible = false;
                btnMainCoursesFavourite.Visible = true;
            }
        }
    }
}
