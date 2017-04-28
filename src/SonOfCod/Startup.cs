using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SonOfCod.Models;

namespace SonOfCod
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFramework()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseIdentity();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
        
        public static void AddTestData(ApplicationDbContext contextTest)
        {
            var content1 = new Models.Content
            {
                Title = "SUSTAINABILITY",
                Details = "Sustainability is not new to us. It has been part of our corporate culture from the beginning. We recognized early on that we needed to protect and preserve our resources to ensure the success of future generations. That is why business decisions were made to expand beyond wild-caught to include sustainable farming in aquaculture. We continuously work to strike a balance between meeting the needs of our business and the sustainable framework we've developed for our seafood resources. It is an on-going process that will be continuously improved, because we know: The future of our fisheries is the future of our business.",
                Url = "https://firstcastlefcu.org/wp-content/uploads/2013/05/SEAFOOD-FESTIVAL.jpg"
            };

            contextTest.Content.Add(content1);

            var content2 = new Models.Content
            {
                Title = "COMMUNITY",
                Details = "Our relationship with people is guided by our Social Responsibility Program. The actions we take and decisions that we make impact our team members, neighbors and consumers. We must promote and protect human rights and fair labor standards, while contributing to the economic and social health of the communities in which we live and work. We are committed to providing a safe and healthy work environment, in compliance with all laws and regulations. For years, Pacific Seafood has been a supporter of City of Hope, Make-A-Wish Foundation, SeaShare, as well as other domestic and international non-profits.",
                Url = "https://s-media-cache-ak0.pinimg.com/originals/31/f8/c2/31f8c2851f15a564c611a099c5fa5941.jpg"
            };

            contextTest.Content.Add(content2);

            var content3 = new Models.Content
            {
                Title = "SELF-GOVERNANCE",
                Details = "Our Self-Governance holds us to a higher standard and is a major competitive difference. Compliance with today's business and industry standards can be challenging. However, our definition of self-governance goes well beyond industry standards, as we set our own standards for best practices. Examples of programs where we define best practices may include food safety, worker safety and product specification compliance. While we set high standards for business performance we also hold our team members accountable to operational excellence.Our company's Diamond Philosophy defines excellence as: Consistently doing your best, and always striving to do better. We feel that philosophy supports our high standards of self - governance.",
                Url = "http://www.mdsg.umd.edu/sites/default/files/images/crab_pickers.jpg"
            };

            contextTest.Content.Add(content3);
        }
    }
}