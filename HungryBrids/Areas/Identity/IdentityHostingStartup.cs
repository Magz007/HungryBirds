using System;
using HungryBirds.Areas.Identity.Data;
using HungryBirds.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(HungryBirds.Areas.Identity.IdentityHostingStartup))]
namespace HungryBirds.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PupilContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PupilContext")));

                services.AddDefaultIdentity<ApplicationUser>()
                    .AddEntityFrameworkStores<PupilContext>();
            });
        }
    }
}