using Generator.DomainApi.Model;
using Generator.Persistence.Adapter.UnitTest.Common;
using NUnit.Framework;

namespace Generator.Domain.UnitTest
{
    public class DealDomainTest
    {
        private DealDomain<Deal> _dealDomain;

        [Test]
        public void GetDealsTest()
        {
            using var context = ApplicationDbContextFactory.Create();
            _dealDomain = new DealDomain<Deal>(context);
            var deals = _dealDomain.GetDeals();
            Assert.AreEqual(3, deals.Count);
            Assert.AreEqual(1, deals[0].Id);
            Assert.AreEqual("ABC", deals[0].Name);
            Assert.AreEqual("ABC deal 123", deals[0].Description);
        }

        [Test]
        public void GetDealByIdTest()
        {
            using var context = ApplicationDbContextFactory.Create();
            _dealDomain = new DealDomain<Deal>(context);
            var deals = _dealDomain.GetDeal(1);
            Assert.AreEqual(1, deals.Id);
            Assert.AreEqual("ABC", deals.Name);
            Assert.AreEqual("ABC deal 123", deals.Description);

        }
    }
}