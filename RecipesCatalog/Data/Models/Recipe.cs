using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Data.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<Product> Products { get; set; }
        public bool IsFavourite = false;
    }
}
