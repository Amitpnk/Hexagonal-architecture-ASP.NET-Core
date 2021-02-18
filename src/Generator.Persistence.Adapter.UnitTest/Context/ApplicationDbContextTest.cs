using Generator.DomainApi.Model;
using Generator.Persistence.Adapter.UnitTest.Common;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Generator.Persistence.Adapter.UnitTest.Context
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertDealIntoDatabase()
        {
            using var context = ApplicationDbContextFactory.Create();
            var Deal = new Deal();
            context.Deals.Add(Deal);
            Assert.AreEqual(EntityState.Added, context.Entry(Deal).State);

            var result = context.SaveChangesAsync();
            Assert.AreEqual(1, result.Result);
            Assert.AreEqual(Task.CompletedTask.Status, result.Status);
            Assert.AreEqual(EntityState.Unchanged, context.Entry(Deal).State);

        }

        [Test]
        public void CanDeleteDealIntoDatabase()
        {
            using var context = ApplicationDbContextFactory.Create();
            var Deal = new Deal();
            context.Deals.Remove(Deal);
            Assert.AreEqual(EntityState.Deleted, context.Entry(Deal).State);
        }
    }
}
