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
            AddRecipeForm addRecipeForm = new AddRecipeForm();
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }
        private void btnRemoveDesert_Click(object sender, EventArgs e)
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
    }
}