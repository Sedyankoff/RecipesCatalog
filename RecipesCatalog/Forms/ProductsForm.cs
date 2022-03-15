using RecipesCatalog.Business;
using RecipesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RecipesCatalogDB;Trusted_Connection=True;");
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
            if (txtBoxProductName.Text == string.Empty)
            {
                lblOutputProducts.Text = "Please provide a name first!";
            }
            else
            {
                if (txtBoxProductType.Text == string.Empty)
                {
                    lblOutputProducts.Text = "Please provide a type first!";
                }
                else
                {
                    con.Open();
                    string commandString = "SELECT Name from dbo.Products";
                    SqlCommand cmd = new SqlCommand(commandString, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    bool found = false;
                    while (dr.Read())
                    {
                        if(txtBoxProductName.Text == dr["Name"].ToString())
                        {
                            lblOutputProducts.Text = "There is already a product with that name!";
                            found = true;
                            break;
                        }
                    }
                    if (!found) 
                    {
                            var name = txtBoxProductName.Text;
                            var type = txtBoxProductType.Text;

                            Product product = new Product();
                            product.Name = name;
                            product.Type = type;

                            productBusiness.AddProduct(product);
                            lblOutputProducts.Text = name + " was succesfully added!";
                            UpdateGrid();
                            Clear();
                    }
                    con.Close();
                }
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count > 0)
            {
                lblOutputProducts.Text = "There is no products to remove!";
            }
            else
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
