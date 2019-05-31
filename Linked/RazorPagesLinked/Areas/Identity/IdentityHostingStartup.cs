using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesLinked.Areas.Identity.Data;

[assembly: HostingStartup(typeof(RazorPagesLinked.Areas.Identity.IdentityHostingStartup))]
namespace RazorPagesLinked.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RazorPagesLinkedIdentityDbContext>(options =>
                    options.UseSqlite(context.Configuration.GetConnectionString("LinkedContext")));

                services.AddDefaultIdentity<LinkedUser>()
                    .AddEntityFrameworkStores<RazorPagesLinkedIdentityDbContext>();
            });
        }
    }
}