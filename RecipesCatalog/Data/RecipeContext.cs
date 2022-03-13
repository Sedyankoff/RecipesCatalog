using RecipesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext()
            : base("name=RecipeContext")
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
