using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF_Kino.Models;

namespace EF_Kino.Configurations
{
    public class CinemaConfiguration : IEntityTypeConfiguration<Kino>
    {
        public void Configure(EntityTypeBuilder<Kino> builder)
        {
            builder.ToTable("Kina");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nazwa).IsRequired();
        }
    }
}
