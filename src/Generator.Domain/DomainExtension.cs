using Generator.DomainApi.Port;
using Microsoft.Extensions.DependencyInjection;

namespace Generator.Domain
{
    public static class DomainExtension
    {
        public static void AddDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IRequestDeal<>), typeof(DealDomain<>));
        }
    }
}
