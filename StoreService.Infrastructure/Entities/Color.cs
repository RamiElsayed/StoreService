using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Color
    {
        public Color(string colorName, Item itemID)
        {
            ColorName = colorName;
            ItemID = itemID;
        }

        public int ID { get; set; }
        public string ColorName { get; set; }
        public Item ItemID { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
