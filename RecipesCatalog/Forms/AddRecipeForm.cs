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
                    lblOutputAddedRecipe.Text = cboxRecipeProducts.SelectedItem.ToString() + " was successfully added to the recipe!";
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

                            string recipeType = cboxRecipeType.SelectedItem.ToString();
                            string recipeName = txtRecipeName.Text;

                            Recipe recipe = new Recipe();
                            recipe.Type = recipeType;
                            recipe.Name = recipeName;
                            recipe.Preparation = txtPreparation.Text;
                            con.Open();
                            string commandString = "SELECT * from dbo.Products WHERE Name = '@productName'";
                            SqlCommand cmd = new SqlCommand(commandString, con);
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
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
                            }
                            con.Close();
                            recipeProducts.Clear();
                            product = new Product();

                            con.Open();
                            commandString = "SELECT Name,Type from dbo.Recipes";
                            cmd = new SqlCommand(commandString, con);
                            SqlDataReader dataR = cmd.ExecuteReader();
                            bool found = false;
                            while (dataR.Read())
                            {
                                if (txtRecipeName.Text == dataR["Name"].ToString() && cboxRecipeType.SelectedItem.ToString() == dataR["Type"].ToString())
                                {
                                    lblOutputAddedRecipe.Text = "There is already a racipe with that name!";
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                recipeBusiness.Add(recipe);
                                lblOutputAddedRecipe.Text = recipeName + " " + recipeType + " was successfully added!";
                                Clear();
                            }
                            con.Close();
                            }
                        }
                    }
                }
            }
        }
    }

