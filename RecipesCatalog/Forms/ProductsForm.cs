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
    public partial class ProductsForm : Form
    {
        private ProductBusiness productBusiness = new ProductBusiness();
        private int editId = 0;
        public ProductsForm()
        {
            InitializeComponent();
            UpdateGrid();
            ResetSelect();
        }
        private void UpdateGrid()
        {
            dataProducts.DataSource = productBusiness.GetAll();
            dataProducts.ReadOnly = true;
            dataProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Clear() 
        {
            txtBoxProductName.Text = string.Empty;
            txtBoxProductType.Text = string.Empty;
        }
        private void DisableSelect()
        {
            dataProducts.Enabled = false;
        }

        private void ResetSelect()
        {
            dataProducts.ClearSelection();
            dataProducts.Enabled = true;
        }

        private void UpdateTextBoxes(int id) 
        {
            Product update = productBusiness.Get(id);

            update.Name = txtBoxProductName.Text;
            update.Type = txtBoxProductType.Text;
        }
        private Product GetEditedProduct()
        {
            Product product = new Product();
            product.Id = editId;

            product.Name = txtBoxProductName.Text;
            product.Type = txtBoxProductType.Text;

            return product;
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count > 0)
            {
                var item = dataProducts.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                if (txtBoxProductType.Text != string.Empty && txtBoxProductName.Text!=string.Empty)
                {
                    Product editedProduct = GetEditedProduct();
                    productBusiness.Update(editedProduct);
                    UpdateTextBoxes(editId);
                    UpdateGrid();
                    Clear();
                    DisableSelect();
                }
            }
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            if (txtBoxProductType.Text != string.Empty && txtBoxProductName.Text != string.Empty)
            {
                var name = txtBoxProductName.Text;
                var type = txtBoxProductType.Text;

                Product product = new Product();
                product.Name = name;
                product.Type = type;

                productBusiness.AddProduct(product);
                UpdateGrid();
                Clear();
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count > 0)
            {
                var item = dataProducts.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.DeleteProduct(id);
                UpdateGrid();
                ResetSelect();
                Clear();
            }
        }
    }
}
