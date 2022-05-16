using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Data.Maps
{
    internal class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.ProName).HasMaxLength(100);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Products).HasForeignKey(a => a.CategoryId);
            builder.ToTable("Products");
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 2,
                    ProName = "kahverengi c100 çanta"

                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    ProName = "siyah c200 çanta"

                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    ProName = "kahverengi a100 ayakkabı"

                }
                );

        }
    }
}
