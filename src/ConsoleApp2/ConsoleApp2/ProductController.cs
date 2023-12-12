using System.Collections.Generic;
using System.Web.Http;

namespace ConsoleApp2
{
    public class ProductController : ApiController
    {
        public Product[] products = new Product[]
        {
            new Product{Id = 1,name = "Ur",Category = "RadioActives",Price = 50000M},
            new Product{Id = 1,name = "Fr",Category = "Unstable",Price = 1500M},
            new Product{Id = 1,name = "Fe",Category = "Business",Price = 456.7M},
            new Product{Id = 1,name = "Meg",Category = "Medicinal",Price = 12.7M},
            new Product{Id = 1,name = "Pl",Category = "RadioActives",Price = 500500M},
            new Product{Id = 1,name = "An",Category = "Unstable",Price = 1200M},
            new Product{Id = 1,name = "Al",Category = "Business",Price = 56.2M},
            new Product{Id = 1,name = "Zn",Category = "Medicinal",Price = 9.5M},
        };
        [HttpGet]
        public IEnumerable<Product> GetAllOrders()
        {
            return products;
        }
    }
}