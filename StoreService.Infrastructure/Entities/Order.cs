using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Order
    {
        public Order(Item itemID, decimal quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }

        public int ID { get; set; }
        public Item ItemID { get; set; }
        public decimal Quantity { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
