using Generator.Persistence.Adapter.Context;
using Generator.Persistence.Adapter.Port;
using Generator.Persistence.Adapter.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Generator.Persistence.Adapter
{
    public static class PersistenceExtensions
    {
        public static void AddPersistence(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("HexaArchConnInMemoryDb"));

            serviceCollection.AddTransient(typeof(IObtainDeal<>), typeof(DealRepository<>));
        }
    }
}
