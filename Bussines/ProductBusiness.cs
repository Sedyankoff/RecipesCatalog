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

        public List<Product> GetAll()
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                return recipeCatalogContext.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                return recipeCatalogContext.Products.Find(id);

            }
        }
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
        public void AddProduct(Product product)
        {
            using (recipeCatalogContext = new RecipeCatalogContext())
            {
                recipeCatalogContext.Products.Add(product);
                recipeCatalogContext.SaveChanges();
            }
        }

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
