using System;
using System.Collections.Generic;
using System.Text;
using MDC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MDC.DAL.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(c => c.Category)
                .WithMany(p => p.Products);

            builder.Property(c => c.Id)
                .HasColumnName("Id");


            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Price)
                .HasColumnType("decimal(5, 2)")
                .IsRequired();
         

        }
    }
}
