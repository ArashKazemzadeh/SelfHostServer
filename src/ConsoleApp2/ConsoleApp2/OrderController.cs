using System.Collections.Generic;
using System.Web.Http;

namespace ConsoleApp2
{
    public class OrderController : ApiController
    {
        public Order[] orders = new Order[]
        {
            new Order{Id = 1,name = "Ur",Category = "RadioActives",Price = 50000},
            new Order{Id = 1,name = "Fr",Category = "Unstable",Price = 1500},
            new Order{Id = 1,name = "Fe",Category = "Business",Price = 456},
            new Order{Id = 1,name = "Meg",Category = "Medicinal",Price = 12},
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
}