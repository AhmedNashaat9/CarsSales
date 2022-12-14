using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using SalesCore.Application.Data;
using SalesCore.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure.Repository
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CarRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }

        public string GetColor(int id)
        {
            return _dbContext.Cars.Find(id).Color;
        }

        public List<Car>GetByType(string type)
        {
            return _dbContext.Cars.Where(c=>c.Type==type).ToList();
            
        }
    }
}
