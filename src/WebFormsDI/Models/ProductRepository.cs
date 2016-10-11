using System.Collections.Generic;

namespace WebFormsDI.Models
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> List()
        {
            return new List<Product>()
            {
                new Product() {Name = "AT-AT", Price = 500000m},
                new Product() {Name = "AT-ST", Price = 200000m},
                new Product() {Name = "Death Star", Price = 10000000m}
            };
        }
    }
}