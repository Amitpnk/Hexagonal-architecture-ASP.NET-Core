using Generator.DomainApi.Model;
using NUnit.Framework;

namespace Generator.DomainApi.UnitTest.Model
{
    public class DealTest
    {
        private readonly Deal _deal;
        private const string Name = "Test Deal name";
        private const string Description = "Test Deal description";

        public DealTest()
        {
            _deal = new Deal();
        }

        [Test]
        public void TestSetAndGetName()
        {
            _deal.Name = Name;
            Assert.AreEqual(Name, _deal.Name);
        }

        [Test]
        public void TestSetAndGetDescription()
        {
            _deal.Description = Description;
            Assert.AreEqual(Description, _deal.Description);
        }
    }
}
