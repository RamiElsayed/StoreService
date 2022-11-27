using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Size
    {
        public Size(string productSize)
        {
            ProductSize = productSize;
        }

        public int ID { get; set; }
        public string ProductSize { get; set; }

        public ICollection<Product> Items { get; set; } = new List<Product>();
    }
}
