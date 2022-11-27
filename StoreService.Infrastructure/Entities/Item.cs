using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Item
    {
        public Item(Product product, Size size, Color color, Order order)
        {
            Product = product;
            Size = size;
            Color = color;
            Order = order;
        }

        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Order Order { get; set; }
    }
}
