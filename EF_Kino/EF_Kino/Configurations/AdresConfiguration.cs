using System;
using System.Collections.Generic;
using System.Text;
using EF_Kino.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Kino.Configurations
{
    public class AdresConfiguration : IEntityTypeConfiguration<Adres>
    {
        public void Configure(EntityTypeBuilder<Adres> builder)
        {
            builder.ToTable("Adresy");
            builder.HasKey(x => x.Id);
            

        }
    }
}
