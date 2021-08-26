using CompositeExample.CompositeDomainEvent.Interfaces;
using CompositeExample.CompositeDomainEvent.Approved;
using CompositeExample.CompositeDomainEvent.Approved.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositeExample.CompositeDomainEvent;

namespace CompositeExample.Extensions
{
    public static class StartupExtensions
    {
        // Dependency Injection pg. 174 - 178
        public static IServiceCollection OrderApprovedExtension(this IServiceCollection services)
        {
            services.AddScoped<IBillingSystem, BillingSystem>();
            services.AddScoped<IInventoryManagement, InventoryManagement>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IMessageService, MessageService>();

            services.AddScoped(container =>
            {
                return new CompositeEventHandler<OrderApproved>(new IEventHandler<OrderApproved>[]
                {
                    new OrderApprovedReceiptSender(container.GetRequiredService<IMessageService>()),
                    new AccountingNotifier(container.GetRequiredService<IBillingSystem>()),
                    new OrderFulfillment(container.GetRequiredService<ILocationService>(), container.GetRequiredService<IInventoryManagement>())
                });
                
            });

            return services;
        }
    }
}
