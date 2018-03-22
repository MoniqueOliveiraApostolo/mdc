using System;
using System.Collections.Generic;
using System.Text;
using MDC.DAL.Context;
using MDC.DAL.Repository;
using MDC.Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MDC.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<ContextMDC>();
        }
    }
}
