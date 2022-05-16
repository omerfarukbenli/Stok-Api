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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.CateName).HasMaxLength(100);
            builder.ToTable("Categories");
            builder.HasData(
                new Category
                {
                    Id = 1,
                    CateName = "Ayakkabı"


                },
                new Category
                {
                    Id = 2,
                    CateName = "Çanta"


                },
                 new Category
                 {
                     Id = 3,
                     CateName = "Cüzdan"


                 }
                 );
        }
    }
}
