﻿using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ServiceInjections
{
    public static class RepManService
    {
        public static IServiceCollection AddRepManServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();

            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

  
            
            services.AddScoped<ICategoryManager,CategoryManager>();
            services.AddScoped<IAppUserManager,AppUserManager>();
            services.AddScoped<IProductManager,ProductManager>();
            services.AddScoped<IOrderManager,OrderManager>();
            services.AddScoped<IOrderDetailManager,OrderDetailManager>();
            services.AddScoped<IProfileManager,ProfileManager>();
            return services;
        }
    }
}
