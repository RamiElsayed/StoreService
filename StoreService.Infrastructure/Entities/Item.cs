using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Item
    {
        public Item(IEnumerable<Item> items, IEnumerable<Color> colors, IEnumerable<Size> sizes, Order order)
        {
            Items = items;
            Colors = colors;
            Sizes = sizes;
            this.Order = order;
        }

        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
        public Order Order { get; set; }
    }
}
