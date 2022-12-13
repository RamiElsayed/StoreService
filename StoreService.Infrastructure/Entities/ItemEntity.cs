using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Entities
{
    public class ItemEntity
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public int Quantity { get; set; }

        public ProductEntity? Product { get; set; }
        public SizeEntity? Size { get; set; }
        public ColorEntity? Color { get; set; }
    }
}
