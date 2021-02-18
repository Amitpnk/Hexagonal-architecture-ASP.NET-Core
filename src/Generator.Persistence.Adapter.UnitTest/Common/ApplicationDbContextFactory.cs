using Generator.DomainApi.Model;
using Generator.Persistence.Adapter.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Generator.Persistence.Adapter.UnitTest.Common
{
    public static class ApplicationDbContextFactory
    {
        public static List<Deal> GetDeals()
        {
            return new List<Deal>()
            {
                new Deal(){Id=1, Name="ABC", Description="ABC deal 123"},
                new Deal(){Id=2, Name="ABC", Description="ABC deal 456"},
                new Deal(){Id=3, Name="ABC", Description="ABC deal 789"},
            };
        }

        public static ApplicationDbContext Create()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new ApplicationDbContext(options);
            context.Database.EnsureCreated();
            context.Deals.AddRange(GetDeals());
            context.SaveChanges();
            return context;
        }
        public static void Destroy(ApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }
    }
}
