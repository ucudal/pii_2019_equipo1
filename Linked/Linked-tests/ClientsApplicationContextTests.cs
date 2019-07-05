using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Xunit;
using Linked.Models;
using Linked.Pages.Clients;
using Linked.Areas.Identity.Data;
using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Linked.Tests
{
        public class ClientsApplicationContextTests
    {
        [Fact]
        public async Task ClientsAreRetrievedTest()
        {
            using (var db = new IdentityContext(Utilities.TestDbContextOptions()))
            {
                // Arrange: seed database with clients
                var expectedClients = SeedTestData.GetSeedingClients();
                await db.AddRangeAsync(expectedClients);
                await db.SaveChangesAsync();

                // Act: retrieve seeded clients from database
                var result = await db.Client.AsNoTracking().ToListAsync();

                // Assert: seeded and retrieved clients match
                var actualClients = Assert.IsAssignableFrom<List<Client>>(result);
                Assert.Equal(
                    expectedClients.OrderBy(a => a.Id).Select(a => a.Name),
                    actualClients.OrderBy(a => a.Id).Select(a => a.Name));
            }
        }
    }




}