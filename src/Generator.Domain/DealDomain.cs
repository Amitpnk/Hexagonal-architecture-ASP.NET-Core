//using Generator.DomainApi.Model;
//using Generator.DomainApi.Port;
//using System.Collections.Generic;

//namespace Generator.Domain
//{
//    public class DealDomain<T> : IRequestDeal<T>
//    {
//        private readonly IObtainDeal<T> _obtainDeal;

//        public DealDomain(IObtainDeal<T> obtainDeal)
//        {
//            _obtainDeal = obtainDeal;
//        }
//        public Deal GetDeal(T id)
//        {
//            return _obtainDeal.GetDeal(id);
//        }

//        public List<Deal> GetDeals()
//        {
//            return _obtainDeal.GetDeals();
//        }
//    }
//}
