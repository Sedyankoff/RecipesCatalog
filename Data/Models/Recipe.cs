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
        public string Name { get; set; }

        public string Products { get; set; }
        public string Preparation { get; set; }

        public bool IsFavourite { get; set; }
    }
}
