using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Size
    {
        public Size(string itemSize, Item itemID)
        {
            ItemSize = itemSize;
            ItemID = itemID;
        }

        public int ID { get; set; }
        public string ItemSize { get; set; }

        public Item ItemID { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
