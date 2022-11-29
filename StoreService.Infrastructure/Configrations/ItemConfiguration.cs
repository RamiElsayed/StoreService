using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreService.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreService.Infrastructure.Configrations
{
    internal class ItemConfiguration : IEntityTypeConfiguration<ItemEntity>
    {
        public void Configure(EntityTypeBuilder<ItemEntity> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(x => x.Product.ID);

            builder.Property(x => x.Product.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.Product.Name).IsRequired();
            builder.Property(x => x.Color).IsRequired();
            builder.Property(x => x.Size).IsRequired();
        }
    }
}
