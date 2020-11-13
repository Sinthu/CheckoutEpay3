using System;
using CheckoutEPay.Areas.Identity.Data;
using CheckoutEPay.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CheckoutEPay.Areas.Identity.IdentityHostingStartup))]
namespace CheckoutEPay.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CheckoutEPayDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CheckoutEPayDbContextConnection")));

                services.AddDefaultIdentity<CheckoutEPayUser>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                } )
                    .AddEntityFrameworkStores<CheckoutEPayDbContext>();
            });
        }
    }
}