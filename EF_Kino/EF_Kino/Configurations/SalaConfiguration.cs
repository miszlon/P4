using EF_Kino.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Configurations
{
    class SalaConfiguration : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.IdSali);
            builder.HasMany(x => x.Miejsce).WithOne(x => x.Sala);
        }
    }
}
