using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Data.Context;

namespace Teste.CrossCutting.DependencyInjection
{
    public static class ConfigureConexaoDB
    {
        public static IServiceCollection ConfigureConexaoRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
