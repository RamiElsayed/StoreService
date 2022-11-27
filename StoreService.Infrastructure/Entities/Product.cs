using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Item
    {
        public Item(int sizeID, int colorID)
        {
            SizeID = sizeID;
            ColorID = colorID;
        }

        public int ID { get; set; }
        public int SizeID { get; set; }
        public int ColorID { get; set; }
        public int OrderID { get; set; }
        public Order? ItemOrder { get; set; }

        public ICollection<Color> Colors { get; set; } = new List<Color>();
        public ICollection<Size> Sizes { get; set; } = new List<Size>();
    }
}
