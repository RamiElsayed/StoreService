using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class Stock
    {
        public int ID { get; set; }
        public decimal Quantity { get; set; }
        public bool InStock { get; set; }
        public Item ItemID { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
