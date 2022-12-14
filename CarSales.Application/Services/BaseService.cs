using AutoMapper;
using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.Services
{
    public class BaseService : IBaseService
    {
        private readonly IBaseRepository<Car> _repository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<Car> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public string Create(CarIM entity)
        {

           
            return _repository.Create(_mapper.Map<Car>(entity));
        }
      

        public string Delete(int ID)
        {
            return _repository.Delete(_repository.GetById(ID));
        }

        public List<CarVM> GetAll()
        {
            return _mapper.Map<List<CarVM>>(_repository.GetAll());
        }

        public CarVM? GetById(int ID)
        {
           if( _repository.GetById(ID) is null)
                return null;
           return _mapper.Map<CarVM>(_repository.GetById(ID));
        }

       public string Update(int id,CarIM entity) 
        {
            var cardb = _repository.GetById(id);
            if (cardb is null)
                return null;
            cardb.Name = entity.Name;
            cardb.Type = entity.Type;
            cardb.Price = entity.price;
            cardb.Color = entity.color;
           return _repository.Update(cardb);
        }
    }
}
