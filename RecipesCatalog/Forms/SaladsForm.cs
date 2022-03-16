﻿using RecipesCatalog.Business;
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
        public SaladsForm()
        {
            InitializeComponent();
            UpdateGrid();
            ResetSelect();
        }

        private void DisableSelect()
        {
            dataSalads.Enabled = false;
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

        private void btnRemoveSalad_Click(object sender, EventArgs e)
        {
            if (dataSalads.SelectedRows.Count > 0)
            {
                var item = dataSalads.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                recipeBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void btnAddSalad_Click(object sender, EventArgs e)
        {
            AddRecipeForm addRecipeForm = new AddRecipeForm();
            addRecipeForm.BringToFront();
            addRecipeForm.Show();
        }

        private void btnOpenSalad_Click(object sender, EventArgs e)
        {

        }
    }
}
