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
    internal class ProductBrandConfigurration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Title).HasMaxLength(100);
            builder.Property(x => x.Summary).HasMaxLength(100);
            builder.HasKey(x => x.Id);

        }
    }
}
