using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Data.Models
{
    public class Recipe
    {
        public List<Product> Products = new List<Product>();
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Preparation { get; set; }

        public bool IsFavourite = false;
    }
}
