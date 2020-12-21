using Generator.Persistence.Adapter.Context;
using Generator.Persistence.Adapter.Entity;
using Generator.Persistence.Adapter.Port;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Persistence.Adapter.Repository
{
    public class DealRepository<T> : IObtainDeal<T>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<DealEntity> table;
        public DealRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            table = _dbContext.Set<DealEntity>();
        }
        public DealEntity GetDeal(T id)
        {
            return table.Find(id);
        }

        public List<DealEntity> GetDeals()
        {
            return table.ToList();
        }

    }
}
