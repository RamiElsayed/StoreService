using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Item
    {
        public Item(Size sizeID, Color colorID)
        {
            SizeID = sizeID;
            ColorID = colorID;
        }

        public int ID { get; set; }
        public Size SizeID { get; set; }
        public Color ColorID { get; set; }

        public ICollection<Color> Colors { get; set; } = new List<Color>();
        public ICollection<Size> Sizes { get; set; } = new List<Size>();
    }
}
