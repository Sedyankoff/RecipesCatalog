using RecipesCatalog.Data;
using RecipesCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesCatalog.Business 
{
    public class ProductBusiness
    {
        private RecipeCatalogContext recipeCatalogContext;


        //Взима всички продукти от базата данни
        public List<Product> GetAll()
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                return recipeCatalogContext.Products.ToList();
            }
        }


        //Взима продукт по ID от базата данни
        public Product Get(int id)
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                return recipeCatalogContext.Products.Find(id);

            }
        }


        //Премахва продукт по ID от базата данни
        public void DeleteProduct(int id)
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                var product = recipeCatalogContext.Products.Find(id);
                if (product != null)
                {
                    recipeCatalogContext.Products.Remove(product);
                    recipeCatalogContext.SaveChanges();
                }
            }
        }


        //Добавя продукт в базата данни
        public void AddProduct(Product product)
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                recipeCatalogContext.Products.Add(product);
                recipeCatalogContext.SaveChanges();
            }
        }


        //Обновява продукт в базата данни
        public void Update(Product product)
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {

                var item = recipeCatalogContext.Products.Find(product.Id);
                if (item != null)
                {
                    recipeCatalogContext.Entry(item).CurrentValues.SetValues(product);
                    recipeCatalogContext.SaveChanges();
                }

            }
        }
    }
}
