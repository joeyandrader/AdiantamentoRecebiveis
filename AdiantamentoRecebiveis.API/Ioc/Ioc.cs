using System;
using AdiantamentoRecebiveis.Application.Services;
using AdiantamentoRecebiveis.Domain.Repositories;
using AdiantamentoRecebiveis.Domain.Services;
using AdiantamentoRecebiveis.Infrastructure.Persistence;
using AdiantamentoRecebiveis.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AdiantamentoRecebiveis.API.Ioc
{
    /// <summary>
    /// Static class for setting up dependency injection.
    /// </summary>
    public static class Ioc
    {
        /// <summary>
        /// Configures the dependency injection container with the necessary services and repositories.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        public static void LoadDependencyInjection(IServiceCollection services)
        {
            #region Services
            services.AddScoped<ICorporateService, CorporateService>();
            services.AddScoped<IAntecipacaoService, AntecipacaoService>();
            services.AddScoped<INotaFiscalService, NotaFiscalService>();
            services.AddScoped<ICartService, CartService>();
            #endregion

            #region Repository
            services.AddScoped<ICorporateRepository, CorporateRepository>();
            services.AddScoped<IAntecipacaoRepository, AntecipacaoRepository>();
            services.AddScoped<INotaFiscalRepository, NotaFiscalRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartNfRepository, CartNfRepository>();
            #endregion
        }
    }
}
