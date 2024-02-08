using Microsoft.Extensions.DependencyInjection;
using DataAccess.Mapping;

namespace AstanaAir.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Profile));
            services.AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            return services;

        }
    }
}
