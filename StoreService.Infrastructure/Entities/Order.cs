using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Order
    {
        public Order(int quantity)
        {
            Quantity = quantity;
        }

        public int ID { get; set; }
        public int Quantity { get; set; }

        public ICollection<Product> Items { get; set; } = new List<Product>();
    }
}
