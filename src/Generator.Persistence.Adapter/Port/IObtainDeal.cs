using Generator.Persistence.Adapter.Entity;
using System.Collections.Generic;

namespace Generator.Persistence.Adapter.Port
{
    public interface IObtainDeal<T>
    {
        List<DealEntity> GetDeals();
        DealEntity GetDeal(T id);
    }
}
