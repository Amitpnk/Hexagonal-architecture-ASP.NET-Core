using System.Collections.Generic;
using System.Linq;
using Generator.DomainApi.Model;
using Generator.DomainApi.Port;
using Microsoft.EntityFrameworkCore;

namespace Generator.Persistence.Adapter.Context
{
    public class DealSet: IDealSet
    {
        private readonly DbSet<Deal> _dealDbSet;

        public DealSet(DbSet<Deal> dealDbSet)
        {
            _dealDbSet = dealDbSet;
        }

        public void AddRange(List<Deal> deals)
        {
            _dealDbSet.AddRange(deals);
        }

        public void Add(Deal deal)
        {
            _dealDbSet.Add(deal);
        }

        public void Remove(Deal deal)
        {
            _dealDbSet.Remove(deal);
        }

        public T Find<T>(int id) where T : Deal
        {
            return _dealDbSet.Find(id) as T;
        }

        public List<T> ToList<T>() where T : Deal
        {
            return _dealDbSet.ToList() as List<T>;
        }
    }
}