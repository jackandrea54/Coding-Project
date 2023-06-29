using System;
using FirstIdentity.Areas.Identity.Data;
using FirstIdentity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FirstIdentity.Areas.Identity.IdentityHostingStartup))]
namespace FirstIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<FirstIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FirstIdentityContextConnection")));

                services.AddDefaultIdentity<FirstIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FirstIdentityContext>();
            });
        }
    }
}