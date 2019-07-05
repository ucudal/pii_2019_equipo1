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
using Linked.Pages.Projects;

namespace Linked.Tests
{
    public class AllocateTests
    {
        // A delegate to perform a test action using a pre-configured ApplicationContext
        private delegate Task TestAction(IdentityContext context);

        // Creates and seeds an ApplicationContext with test data; then calls  test action.
        private async Task PrepareTestContext(TestAction testAction)
        {
            // Database is in memory as long the connection is open
            var connection = new SqliteConnection("DataSource=:memory:");
            try
            {
                connection.Open();

                var options = new DbContextOptionsBuilder<IdentityContext>()
                    .UseSqlite(connection)
                    .Options;

                // Create the schema in the database and seeds with test data
                using (var context = new IdentityContext(options))
                {
                    context.Database.EnsureCreated();
                    SeedTestData.Initialize(context);

                    await testAction(context);
                }
            }
            finally
            {
                connection.Close();
            }
        }

        [Fact]
        public async Task OnGetAsyncPopulatesPageModel()
        {
            // Arrange: seed database with test data
            await PrepareTestContext(async(context) =>
            {
                    var expectedTechnician = SeedTestData.GetSeedingTechnicians()[0];
                    var expectedProject = SeedTestData.GetSeedingProjects()[0];

                    // Act: allocate tech to proj
                    var TestedAllocate = new AllocateModel(context);
                    await TestedAllocate.OnGetAsync(expectedProject.ProjectID);

                    // Assert: employ correctly saved to db
                    
                    TestedAllocate.AllocateTechnician(expectedProject.ProjectID,expectedTechnician.TechnicianID);

                    List<Employ> ActualEmploys = await context.Employ.AsNoTracking().ToListAsync();

                    Assert.True(ActualEmploys.Count>0);

                    Assert.Equal(ActualEmploys[0].TechnicianID,expectedTechnician.TechnicianID);

                    Assert.Equal(ActualEmploys[0].ProjectID,expectedProject.ProjectID);

            });
        }
    }
}