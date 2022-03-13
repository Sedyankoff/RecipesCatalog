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
        private ProductBusiness productBusiness = new ProductBusiness();
        private int editId = 0;
        public AppetizerForm()
        {
            InitializeComponent();
            ResetSelect();
            UpdateGrid();
        }



        private void DisableSelect()
        {
            dataAppetizer.Enabled = false;
        }

        private void ResetSelect()
        {
            dataAppetizer.ClearSelection();
            dataAppetizer.Enabled = true;
        }
        ///
        private void UpdateGrid()
        {
            dataAppetizer.DataSource = productBusiness.GetAll();
            dataAppetizer.ReadOnly = true;
            dataAppetizer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //
        private void AppetizerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveAppetizer_Click(object sender, EventArgs e)
        {
            if (dataAppetizer.SelectedRows.Count > 0)
            {
                var item = dataAppetizer.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.DeleteProduct(id);
                UpdateGrid();
                ResetSelect();
            }
        }

       

        private void btnAddAppetizer_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm();
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }
    }
}
