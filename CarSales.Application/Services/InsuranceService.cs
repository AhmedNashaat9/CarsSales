using AutoMapper;
using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.Services
{
    public class InsuranceService : IInsuranceService
    {
        private readonly IInsuranceRepository _repository;
        private readonly IMapper _mapper;
        public InsuranceService( IInsuranceRepository repository1, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository1;
        }
        public string Create(InsuranceIM entity)
        {
           return _repository.Create(_mapper.Map<InsuranceContract>(entity));


        }

        public List<InsuranceVM> GetAll()
        {
            return _mapper.Map<List<InsuranceVM>>(_repository.GetAll());

        }

        public InsuranceVM? GetByCarId(int carID)
        {
            return _mapper.Map<InsuranceVM>(_repository.GetByCarId(carID));

        }
        public void UpdateValid(int carid)
        {
            var x = _repository.GetByCarId(carid);

            x.IsValid = false;

            _repository.Update(x);
        }
        public string Delete(int ID)
        {
            return _repository.Delete(_repository.GetByCarId(ID));
        }
    }
}
