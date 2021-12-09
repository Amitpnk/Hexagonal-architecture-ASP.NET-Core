using System.Collections.Generic;
using Generator.DomainApi.Model;

namespace Generator.DomainApi.Port
{
    public interface IDealSet
    {
        void AddRange(List<Deal> getDeals);
        void Add(Deal deal);
        void Remove(Deal deal);
        T Find<T>(int id) where T : Deal;
        List<T> ToList<T>() where T : Deal;
    }
}