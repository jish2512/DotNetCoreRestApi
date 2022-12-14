using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreRestApi.BusinessManager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DotNetCoreRestApi.DBContexts;
using AutoMapper;
using Newtonsoft.Json.Serialization;

namespace DotNetCoreRestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<UserContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("ZipperConnection")));
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //3types to add services AddSingelton(same for everyrequest)--
            //AddScoped(create  once per client request
            //AddTransient(new instance everytime)
            //services.AddTransient<IUserDetails, UserDetails>();

            services.AddScoped<IUserDetails, UserDetails>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
