using EF_Kino.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Configurations
{
    public class BiletConfiguration : IEntityTypeConfiguration<Bilet>
    {
        public void Configure(EntityTypeBuilder<Bilet> builder)
        {
            builder.ToTable("Bilety");

        }
    }
}
