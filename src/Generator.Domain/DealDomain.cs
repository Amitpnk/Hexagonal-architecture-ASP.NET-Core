using Generator.DomainApi.Model;
using Generator.DomainApi.Port;
using Generator.Persistence.Adapter.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Domain
{
    public class DealDomain<T> : IRequestDeal<T>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Deal> table;

        public DealDomain(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.Set<Deal>();
        }
        public Deal GetDeal(T id)
        {
            return table.Find(id);
        }

        public List<Deal> GetDeals()
        {
            return table.ToList();
        }
    }
}
