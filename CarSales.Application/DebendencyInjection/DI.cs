﻿using CarSales.Application.IServices;
using CarSales.Application.Services;
using CarSales.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using SalesCore.Application.Data;
using SalesCore.Application.IRepository;
using SalesCore.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.DebendencyInjection
{
    public static class DI
    {
        public static void OurServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped < IBaseRepository<Car>, BaseRepository<Car>>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
