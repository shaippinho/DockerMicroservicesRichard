using Dominio.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Extensoes
{
    public static class ServiceCollectionExtensions
    {
        private const string ConfigExternalCadastroProduto = "External:CadastroProduto";

        public static IServiceCollection AddExternalApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            var baseUrlCadastroProduto = configuration[ConfigExternalCadastroProduto];

#pragma warning disable CS8604 // Possível argumento de referência nula.
            services.AddRefitClient<IProdutoRefit>()
                .ConfigureHttpClient(config => config.BaseAddress = new Uri(baseUrlCadastroProduto));
#pragma warning restore CS8604 // Possível argumento de referência nula.

            return services;
        }
    }
}
