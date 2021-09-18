using Microsoft.EntityFrameworkCore;
using System;
using ClassInfra.Models;

namespace ClassInfra
{
    public class ClassDB : DbContext
    {
        public ClassDB(DbContextOptions options) : base(options) { }
        public DbSet<Amigo> Amigos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=tcp:efgazinfnetdb.database.windows.net,1433;Initial Catalog=tp3db;Persist Security Info=False;User ID=administrador;Password=SRV@meisteer2021;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
