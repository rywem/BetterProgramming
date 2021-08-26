using CompositeExample.CompositePattern.Interfaces;
using CompositeExample.CompositePattern;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositeExample.Extensions;

namespace CompositeExample
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
            services.AddSingleton<INotificationService, BillingService>();
            services.AddSingleton<INotificationService, FulfillmentService>();
            services.AddSingleton<INotificationService, MessageService>();

            services.AddSingleton<INotificationService>(container =>
            {
                var billingService = container.GetRequiredService<BillingService>();
                var fulfillmentService = container.GetRequiredService<FulfillmentService>();
                var messageService = container.GetRequiredService<MessageService>();

                return new CompositeNotificationService(new INotificationService[]
                {
                    billingService,
                    fulfillmentService,
                    messageService
                });
            });

            // Domain Events Composite Pattern
            services.OrderApprovedExtension();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CompositeExample", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CompositeExample v1"));
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
