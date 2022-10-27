using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using shopping2.Areas.Identity.Data;
using shopping2.Data;

[assembly: HostingStartup(typeof(shopping2.Areas.Identity.IdentityHostingStartup))]
namespace shopping2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<shopping2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("shopping2ContextConnection")));

                services.AddDefaultIdentity<shopping2User>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;

                } )
                    .AddEntityFrameworkStores<shopping2Context>();
            });
        }
    }
}