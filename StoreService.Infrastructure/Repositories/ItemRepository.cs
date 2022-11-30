using Microsoft.EntityFrameworkCore;
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

        public Task<List<ItemEntity>> GetAll()
        {
            return db.Set<ItemEntity>().ToList();
        }
    }
}
