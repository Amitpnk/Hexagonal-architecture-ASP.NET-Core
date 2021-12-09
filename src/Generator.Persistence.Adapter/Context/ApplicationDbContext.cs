using Generator.DomainApi.Model;
using Generator.DomainApi.Port;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Generator.Persistence.Adapter.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Deal> DbDeals { get; set; }

        private IDealSet _deals;

        public IDealSet Deals
        {
            get { return _deals ??= new DealSet(Set<Deal>()); }
            set => _deals = value;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
