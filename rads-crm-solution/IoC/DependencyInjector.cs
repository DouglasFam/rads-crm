using Data.Repository;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
        }
    }
}
