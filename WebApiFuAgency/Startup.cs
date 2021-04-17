using Employee.Data;
using Employee.Repository;
using Employee.Repository.impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFuAgency
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApiFuAgency", Version = "v1" });
            });
            services.AddHealthChecks();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                });
            });

            services.AddTransient<IImpiegatiRepository, ImpiegatiRepository>();
            services.AddTransient<IDipartimentiRepository, DipartimentiRepository>();

            services.AddDbContext<RolmexContext>(option => option.UseSqlServer(Configuration.GetConnectionString("FuAgency"), b => b.MigrationsAssembly("WebApiFuAgency")));
            services.AddAutoMapper(typeof(Startup));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiFuAgency v1"));
            }
            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseCors();

            app.UseEndpoints(endpoint =>{
                endpoint.MapControllers();
            });
        }
    }
}
