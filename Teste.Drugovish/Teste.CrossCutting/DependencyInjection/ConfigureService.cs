using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Data.Repositories;
using Teste.Domain.Interfaces;
using Teste.Domain.Interfaces.Services.Cliente;
using Teste.Domain.Interfaces.Services.Gerente;
using Teste.Domain.Interfaces.Services.Grupo;
using Teste.Services.Services;

namespace Teste.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddScoped<IClienteServices, ClienteServices>();
            serviceCollection.AddScoped<IGerenteServices, GerenteServices>();
            serviceCollection.AddScoped<IGrupoServices, GrupoServices>();
            
        }
    }
}
