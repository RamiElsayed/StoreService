using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderID { get; set; }
        public Order? ProductOrder { get; set; }

        public ICollection<Color> Colors { get; set; } = new List<Color>();
        public ICollection<Size> Sizes { get; set; } = new List<Size>();
    }
}
