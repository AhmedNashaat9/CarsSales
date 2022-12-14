using AutoMapper;
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
    public class CarService : BaseService,ICarService
    {
        private readonly ICarRepository _repository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public List<CarVM> GetByType(string type)
        {
            var carDb = _repository.GetByType(type);
            var result = _mapper.Map<List<CarVM>>(carDb);
            return result;

        }

        public string GetColor(int id)
        {
            return _repository.GetColor(id);
        }
    }
}
