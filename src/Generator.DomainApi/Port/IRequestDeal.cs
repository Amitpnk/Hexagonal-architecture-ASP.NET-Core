using Generator.DomainApi.Model;
using System.Collections.Generic;

namespace Generator.DomainApi.Port
{
    public interface IRequestDeal<T>
    {
        List<Deal> GetDeals();
        Deal GetDeal(T id);
    }
}
