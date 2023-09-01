using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.PictureUrl).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x => x.ProductBrand);  
            builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x => x.PropertyTypeId);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Summary).HasMaxLength(100);
        }
    }
}
