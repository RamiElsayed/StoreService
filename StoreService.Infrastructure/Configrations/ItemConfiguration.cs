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
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.ProductId, x.SizeId, x.ColorId }).IsUnique();

            builder.Property(x => x.Quantity).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.Items).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Size).WithMany(x => x.Items).HasForeignKey(x => x.SizeId);
            builder.HasOne(x => x.Color).WithMany(x => x.Items).HasForeignKey(x => x.ColorId);
        }
    }
}
