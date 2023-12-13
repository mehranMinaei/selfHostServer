using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace selfHostServer
{
    public class OrderController : ApiController
    {
        Order[] orders = new Order[] {
            new Order {Id= 1, Name= "order 1 " , Category="cat1", Price = 1 },
            new Order {Id= 2, Name= "order21 " , Category="cat2", Price = 10 },
            new Order {Id= 3, Name= "order10 " , Category="cat3", Price = 100 },
        };

        public IEnumerable<Order> GetOrders() {
            return orders;
        }
    }

    public class ProductConteoller : ApiController
    {
        Product[] products = new Product[] {
        new Product { Id= 1 , Name = "Product 1"},
        new Product {Id =2 , Name="Product 2" } 
        };


        [HttpGet]
        public IEnumerable<Product> AllProduct()
        {
            return products;
        }

    }

    public class Order { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
}
