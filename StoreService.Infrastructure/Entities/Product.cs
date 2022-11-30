using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Product
    {
        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Color> Colors { get; set; } = new List<Color>();
        public ICollection<Size> Sizes { get; set; } = new List<Size>();
    }
}
