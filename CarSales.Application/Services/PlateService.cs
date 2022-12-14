using AutoMapper;
using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using SalesCore.Application.IRepository;
using SalesCore.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.Services
{
    public class PlateService : IPlateService
    {
        private readonly IBaseRepository<Plate> _repository;
        private readonly IMapper _mapper;
        public PlateService(IBaseRepository<Plate> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public string Create(PlateIM entity)
        {
            if (entity.FrontPlate != entity.RearPlate)
                return "frontplate and rearplate must be equal";
           return _repository.Create(_mapper.Map<Plate>(entity));
        }

        public string Delete(int ID)
        {
            return _repository.Delete(_repository.GetById(ID));
        }

        public List<PlateVm> GetAll()
        {
            var result=_mapper.Map<List<PlateVm>>(_repository.GetAll());
            return result;
        }

        public PlateVm? GetById(int ID)
        {
            if (_repository.GetById(ID) is null)
                return null;
            return _mapper.Map<PlateVm>(_repository.GetById(ID));
        }

        //public string Update(int id, PlateIM entity)
        //{
        //}
    }
}
