using AutoMapper;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.IServices
{
    public interface ICarService : IBaseService
    {
        string GetColor(int id);
        List<CarVM> GetByType(string type);
    }
}
