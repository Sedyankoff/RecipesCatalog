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
    public partial class AddRecipeForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RecipesCatalogDB;Trusted_Connection=True;");
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        private List<string> recipeProducts = new List<string>();
        private Product product = new Product();

        public AddRecipeForm()
        {
            InitializeComponent();
            cboxDisplay();
        }

        private void cboxRecipeProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cboxDisplay()
        {
            con.Open();
            string commandString = "SELECT Name from dbo.Products";
            SqlCommand cmd = new SqlCommand(commandString, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboxRecipeProducts.Items.Add(dr["Name"].ToString());
                cboxRecipeProducts.DisplayMember = (dr["Name"].ToString());
            }
            con.Close();
        }

        private void btnAddProductRecipe_Click(object sender, EventArgs e)
        {
            if (cboxRecipeProducts.SelectedItem == null)
            {
                lblOutputAddedRecipe.Text = "Please select a product first!";
            }
            else
            {
                if (recipeProducts.Contains(cboxRecipeProducts.SelectedItem.ToString()))
                {
                    lblOutputAddedRecipe.Text = "This product is already added!";
                }
                else
                {
                    recipeProducts.Add(cboxRecipeProducts.SelectedItem.ToString());
                    lblOutputAddedRecipe.Text = "Product added successfully!";
                }
            }

        }

        private void Clear()
        {
            cboxRecipeType.SelectedItem = null;
            txtRecipeName.Text = string.Empty;
            cboxRecipeProducts.SelectedItem = null;
            txtPreparation.Text = string.Empty;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (cboxRecipeType.SelectedItem == null)
            {
                lblOutputAddedRecipe.Text = "Please select a recipe type first!";
            }
            else
            {
                if (txtRecipeName.Text == string.Empty)
                {
                    lblOutputAddedRecipe.Text = "Please provide a name for the recipe!";
                }
                else
                {
                    if (recipeProducts.Count == 0)
                    {
                        lblOutputAddedRecipe.Text = "Add at least one product!";
                    }
                    else
                    {
                        if (txtPreparation.Text == string.Empty)
                        {
                            lblOutputAddedRecipe.Text = "Please provide a preparation first!";
                        }
                        else
                        {
                            con.Open();
                            string commandStringNameCheck = "SELECT Name from dbo.Recipes";
                            SqlCommand cmd = new SqlCommand(commandStringNameCheck, con);
                            SqlDataReader dr = cmd.ExecuteReader();
                            bool found = false;
                            while (dr.Read())
                            {
                                if (txtRecipeName.Text == dr["Name"].ToString())
                                {
                                    lblOutputAddedRecipe.Text = "There is already a recipe with that name!";
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Recipe recipe = new Recipe();
                                recipe.Type = cboxRecipeType.SelectedItem.ToString();
                                recipe.Name = txtRecipeName.Text;
                                recipe.Preparation = txtPreparation.Text;
                                string commandString = "SELECT * from dbo.Products WHERE Name = '@productName'";
                                cmd = new SqlCommand(commandString, con);
                                dr = cmd.ExecuteReader();
                                foreach (var productName in recipeProducts)
                                {
                                    cmd.Parameters.AddWithValue("@productName", productName);
                                    dr = cmd.ExecuteReader();
                                    while (dr.Read())
                                    {
                                        product.Id = int.Parse(dr["Id"].ToString());
                                        product.Name = dr["Name"].ToString();
                                        product.Type = dr["Type"].ToString();
                                    }
                                    recipe.Products.Add(product);
                                }
                                con.Close();
                                recipeProducts.Clear();
                                product = new Product();
                                recipeBusiness.Add(recipe);
                                Clear();
                                MessageBox.Show("Successfully added!");
                            }
                        }
                    }
                }
            }
        }
    }
}
