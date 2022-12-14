using CarSales.Core.Models;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Infrastructure.IRepository
{
    public interface IInsuranceRepository : IBaseRepository<InsuranceContract>
    {
        InsuranceContract GetByCarId(int carid);
    }
}
