using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using SalesCore.Application.Data;
using SalesCore.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure.Repository
{
    public class InsuranceRepository : BaseRepository<InsuranceContract>, IInsuranceRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public InsuranceRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }

        InsuranceContract IInsuranceRepository.GetByCarId(int carid)
        {
            return _dbContext.insuranceContracts.Where(c=>c.CarId==carid).FirstOrDefault();

        }
    }
}
