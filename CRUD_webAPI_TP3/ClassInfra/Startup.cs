using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfra
{
    public static class Startup
    {
        public static void AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ClassDB>(options => options.UseSqlServer(@"Server=tcp:efgazinfnetdb.database.windows.net,1433;Initial Catalog=tp3db;Persist Security Info=False;User ID=administrador;Password=SRV@meisteer2021;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));



        }


    }
}
