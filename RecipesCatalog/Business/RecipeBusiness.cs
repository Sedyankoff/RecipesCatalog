using RecipesCatalog.Data;
using RecipesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Business
{
    class RecipeBusiness
    {
        private RecipeContext recipeContext;

        public List<Recipe> GetAll()
        {
            using (recipeContext = new RecipeContext())
            {
                return recipeContext.Recipes.ToList();
            }
        }

        public Recipe Get(int id)
        {
            using (recipeContext = new RecipeContext())
            {
                return recipeContext.Recipes.Find(id);

            }
        }

        public void Add(Recipe recipe)
        {
            using (recipeContext = new RecipeContext())
            {
                recipeContext.Recipes.Add(recipe);
                recipeContext.SaveChanges();

            }
        }

        public void Update(Recipe recipe)
        {
            using (recipeContext = new RecipeContext())
            {

                var item = recipeContext.Recipes.Find(recipe.Id);
                if (item != null)
                {
                    recipeContext.Entry(item).CurrentValues.SetValues(recipe);
                    recipeContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (recipeContext = new RecipeContext())
            {
                var recipe = recipeContext.Recipes.Find(id);
                if (recipe != null)
                {
                    recipeContext.Recipes.Remove(recipe);
                    recipeContext.SaveChanges();
                }
            }
        }
    }
}
