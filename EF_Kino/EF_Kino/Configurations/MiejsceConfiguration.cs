using EF_Kino.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Configurations
{
    class MiejsceConfiguration : IEntityTypeConfiguration<Miejsce>
    {
        public void Configure(EntityTypeBuilder<Miejsce> builder)
        {
            builder.ToTable("Miejsca");
        }
    }
}
