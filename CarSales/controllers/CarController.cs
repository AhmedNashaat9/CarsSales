using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarSales.Api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IBaseService _productService;

        public CarController(IBaseService productService)
        {
            _productService = productService;
        }

        [HttpPost("Post")]
        
        public ActionResult<string> Create(CarIM car)
        {
            return Ok(_productService.Create(car));
        }
        [HttpGet]
        public ActionResult<CarVM> Get()
        {
            var result = _productService.GetAll();
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete]
        public ActionResult<string> Delete (int ID)
        {
            var result = _productService.Delete(ID);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpPut]
        public ActionResult<string> Update(Car car)
        {
            if (car.Id == null)
                return NotFound();
            var result = _productService.Update(car);
            
            return Ok(result);
        }
    }
}
