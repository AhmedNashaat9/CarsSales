using CarSales.Core.Models;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure.IRepository
{
    public interface ICarRepository : IBaseRepository<Car> 
    {
        string GetColor(int id);
        List<Car> GetByType(string type);
    }
}
