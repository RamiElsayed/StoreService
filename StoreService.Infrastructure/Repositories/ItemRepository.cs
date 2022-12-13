using Microsoft.EntityFrameworkCore;
using StoreService.Core.Queries;
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
            return db.Set<ProductEntity>()
                .Select(p => new
                {
                    Name = p.Name,
                    Colors = p.Items.Select(i => i.Color!.Name).Distinct().ToList(),
                    Sizes = p.Items.Select(i => i.Size!.Name).Distinct().ToList()
                })
                .Select(p => new ItemResponse(p.Name, p.Colors, p.Sizes))
                .ToListAsync();
        }

        public Task<ItemResponse> Get(GetItemQuery query)
        {
            return db.Set<ProductEntity>()
                .Where(i => i.Id == query.ProductId)
                .Select(p => new
                {
                    Name = p.Name,
                    Colors = p.Items.Select(i => i.Color!.Name).Distinct().ToList(),
                    Sizes = p.Items.Select(i => i.Size!.Name).Distinct().ToList()
                })
                .Select(p => new ItemResponse(p.Name, p.Colors, p.Sizes))
                .SingleAsync();
        }
    }
}
