using EF_Kino.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using EF_Kino.Models;


namespace EF_Kino
{
    
    public class EF_KinoContext : DbContext
    {

        public static readonly ILoggerFactory Logger = LoggerFactory.Create(builder => {builder.AddConsole();});
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (LocalDb)\\NewDB2;Database = EF_Kino; Trusted_Connection = True;").UseLoggerFactory(Logger);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
