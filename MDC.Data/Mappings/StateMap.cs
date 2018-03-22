using System;
using System.Collections.Generic;
using System.Text;
using MDC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MDC.DAL.Mappings
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {

            builder.HasOne(c => c.Country)
                .WithMany(s => s.States);

            builder.Property(c => c.Id)
                .HasColumnName("Id");

 
            builder.Property(c => c.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
