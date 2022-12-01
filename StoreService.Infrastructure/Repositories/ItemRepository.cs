using Microsoft.EntityFrameworkCore;
using StoreService.Core.Responses;
using StoreService.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DbContext db;

        public ItemRepository(DbContext db)
        {
            this.db = db;
        }

        public Task<List<ItemResponse>> GetAll()
        {
            return db.Set<Product>()
                .Select(p => new
                {
                    Name = p.Name,
                    Colors = p.Items.Select(i => i.Color.ProductColor).Distinct().ToList(),
                    Sizes = p.Items.Select(i => i.Size.ProductSize).Distinct().ToList()
                })
                .Select(p => new ItemResponse(p.Name, p.Colors, p.Sizes))
                .ToListAsync();
        }
    }
}
