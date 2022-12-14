using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUnitTest.FakeRepositories
{
    public class InsuranceFakeRepository : IInsuranceRepository
    {
        private readonly List<InsuranceContract> _Insurance;

        public InsuranceFakeRepository()
        {
            _Insurance = new List<InsuranceContract>()
            {
                new InsuranceContract()
                {
                    CarId = 1,
                    InsuranceAmount= 220,
                    InsuranceDate= DateTime.Now,
                    InsuranceName = "seee",
                    InsuranceNumber = Guid.NewGuid(),
                    IsValid = true,
                },
                new InsuranceContract()
                {
                    CarId = 2,
                    InsuranceAmount= 233,
                    InsuranceDate= DateTime.Now,
                    InsuranceName = "sdd",
                    InsuranceNumber = Guid.NewGuid(),
                    IsValid = true,
                },
                new InsuranceContract()
                {
                    CarId = 3,
                    InsuranceAmount= 248,
                    InsuranceDate= DateTime.Now,
                    InsuranceName = "sssf",
                    InsuranceNumber = Guid.NewGuid(),
                    IsValid = true,
                },
                new InsuranceContract()
                {
                    CarId = 4,
                    InsuranceAmount= 390,
                    InsuranceDate= DateTime.Now,
                    InsuranceName = "dddf",
                    InsuranceNumber = Guid.NewGuid(),
                    IsValid = true,
                },

            };
        }
        string IBaseRepository<InsuranceContract>.Create(InsuranceContract entity)
        {
            _Insurance.Add(entity);
            return "ok";
        }

        string IBaseRepository<InsuranceContract>.Delete(InsuranceContract entity)
        {
            _Insurance.Remove(entity);
            return "deleted";
        }

        List<InsuranceContract> IBaseRepository<InsuranceContract>.GetAll()
        {
            return _Insurance.ToList();

        }

        InsuranceContract IInsuranceRepository.GetByCarId(int carid)
        {
            return _Insurance.Where(c => c.CarId == carid).FirstOrDefault();
        }

        InsuranceContract? IBaseRepository<InsuranceContract>.GetById(int entity)
        {
            throw new NotImplementedException();
        }

        string IBaseRepository<InsuranceContract>.Update(InsuranceContract entity)
        {
            throw new NotImplementedException();
        }
    }
}
