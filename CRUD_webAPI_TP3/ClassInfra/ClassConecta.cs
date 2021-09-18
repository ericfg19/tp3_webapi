using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfra
{

    public class BloggingContextFactory : IDesignTimeDbContextFactory<ClassDB>
    {
        public ClassDB CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClassDB>();
            optionsBuilder.UseSqlServer(
                @"Server=tcp:efgazinfnetdb.database.windows.net,1433;Initial Catalog=tp3db;Persist Security Info=False;User ID=administrador;Password=SRV@meisteer2021;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        

            return new ClassDB(optionsBuilder.Options);
        }
    }

}
