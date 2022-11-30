using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class ItemEntity
    {
        public ItemEntity(Product product, Size size, Color color,int quantity)
        {
            Product = product;
            Size = size;
            Color = color;
            Quantity = quantity;
        }

        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public int Quantity { get; set; }
    }
}
