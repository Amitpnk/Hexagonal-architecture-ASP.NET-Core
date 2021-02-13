using Generator.DomainApi.Model;
using System.Collections.Generic;

namespace Generator.DomainApi.Port
{
    public interface IObtainDeal<T>
    {
        List<Deal> GetDeals();
        Deal GetDeal(T id);
    }
}
