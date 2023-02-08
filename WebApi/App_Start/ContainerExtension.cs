using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using Microsoft.Extensions.DependencyInjection;
using WBL;

namespace WebApi
{
    public static class ContainerExtension
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess, DataAccess>();
            services.AddTransient<IProductoService, ProductoService>();
            services.AddTransient<IFacturaService, FacturaService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IRolesService, RolesService>();
            services.AddTransient<IReporte_ProductoService, Reporte_ProductoService>();



            services.AddTransient<IUsuariosService, UsuariosService>();
            return services;
        }
    }
}
