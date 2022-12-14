using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.Services;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using CarSales.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarSales.Api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IBaseService _BaseService;
        private readonly ICarService _CarService;
        private readonly IPlateService _PlateService;

        public CarController(IBaseService BaseService,ICarService CarService, IPlateService plateService)
        {
            _BaseService = BaseService;
            _CarService = CarService;
            _PlateService = plateService;
        }

       
        [HttpPost]
        public ActionResult<string> Create( CarIM car)
        {
            return Ok(_BaseService.Create(car));
        }

        [HttpGet("list")]
        public ActionResult<List<CarVM>> Get()
        {
            var result = _BaseService.GetAll();
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult<CarVM> GetById(int id)
        {
            var result = _BaseService.GetById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult<string> DeletePlate (int ID)
        {
            var result = _BaseService.Delete(ID);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpPut("{id}")]
        public ActionResult<string> Update(int id,CarIM car)
        {
            
            var result = _BaseService.Update(id,car);
            
            return Ok(result);
        }
        [HttpGet("color")]

        public ActionResult<string> GetColor(int id)
        {

            return _CarService.GetColor(id);
        }
        [HttpGet("type")]

        public ActionResult<List<CarVM>> GetByType(string type)
        {

            return _CarService.GetByType(type);
        }
    }
}
