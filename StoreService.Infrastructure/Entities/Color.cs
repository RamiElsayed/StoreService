using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Color
    {
        public Color(string productColor)
        {
            ProductColor = productColor;
        }

        public int ID { get; set; }
        public string ProductColor { get; set; }

        public ICollection<Product> Items { get; set; } = new List<Product>();
    }
}
