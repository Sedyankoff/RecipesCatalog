using RecipesCatalog.Data;
using RecipesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Business
{
    public class RecipeBusiness
    {
        private RecipeCatalogContext recipeContext;


        //Взима всички рецепти от базата данни
        public List<Recipe> GetAll()
        {
            using (recipeContext = new RecipeCatalogContext())
            {
                return recipeContext.Recipes.ToList();
            }
        }


        //Взима всички рецепти, които отговарят на първоначален зададен тип
        public List<Recipe> GetAllByType(string type)
        {
            using (recipeContext = new RecipeCatalogContext())
            {
                List<Recipe> recipes = recipeContext.Recipes.ToList();
                List<Recipe> all = new List<Recipe>();

                foreach (var item in recipes)
                {
                    if (item.Type.ToString() == type)
                    {
                        all.Add(item);
                    }
                }
                return all;
            }
        }


        //Взима всички рецепти ,които имат стойност за променливата "IsFavourite = true"
        public List<Recipe> GetAllFavourites()
        {
            using (recipeContext = new RecipeCatalogContext())
            {
                List<Recipe> recipes = recipeContext.Recipes.ToList();
                List<Recipe> all = new List<Recipe>();

                foreach (var item in recipes)
                {
                    if (item.IsFavourite == true)
                    {
                        all.Add(item);
                    }
                }
                return all;
            }
        }


        //Взима рецепта по ID
        public Recipe Get(int id)
        {
            using (recipeContext = new RecipeCatalogContext())
            {
                return recipeContext.Recipes.Find(id);

            }
        }


        //Добавя рецепта в базата данни 
        public void Add(Recipe recipe)
        {
            using (recipeContext = new RecipeCatalogContext())
            {
                recipeContext.Recipes.Add(recipe);
                recipeContext.SaveChanges();

            }
        }


        //Обновява рецепта в базата данни
        public void Update(Recipe recipe)
        {
            using (recipeContext = new RecipeCatalogContext())
            {

                var item = recipeContext.Recipes.Find(recipe.Id);
                if (item != null)
                {
                    recipeContext.Entry(item).CurrentValues.SetValues(recipe);
                    recipeContext.SaveChanges();
                }

            }
        }


        //Премахва рецепта от базата данни
        public void Delete(int id)
        {
            using (recipeContext = new RecipeCatalogContext())
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
