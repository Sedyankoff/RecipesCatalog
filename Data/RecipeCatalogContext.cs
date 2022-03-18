using RecipesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Data
{

    //Създава базата данни и таблиците за Продуктите(Products) и Рецептите(Recipes)
    public class RecipeCatalogContext : DbContext
    {
        public RecipeCatalogContext()
            : base("name=RecipeContext") 
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
