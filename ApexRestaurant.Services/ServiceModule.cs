using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMenu;

namespace ApexRestaurant.Services
{
    public class ServicesModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMenuService, MenuService>();
        }
        
    }
}