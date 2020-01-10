using System.Collections.Generic;
using api.Interfaces;
using model;

namespace api.Repositories
{
    public class ProductRepository : IRepoProduct
    {
        public List<Product> GetIndexData()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Phone",
                Price = 300,
                Description = "Samsung"
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Notebook",
                Price = 2300,
                Description = "MSI"
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Monitor",
                Price = 500,
                Description = "Dell"
            });
            return products;
        }
    }
}