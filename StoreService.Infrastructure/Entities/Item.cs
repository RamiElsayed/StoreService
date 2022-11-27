using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Item
    {
        public int ID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Stock StockId { get; set; }
    }
}
