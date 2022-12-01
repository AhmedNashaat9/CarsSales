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

        [HttpPost]

        public ActionResult<string> Create(CarIM car)
        {
            return Ok(_productService.Create(car));
        }

        [HttpGet("list")]
        public ActionResult<List<CarVM>> Get()
        {
            var result = _productService.GetAll();
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpGet("{id}")]
        public ActionResult<CarVM> GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete("{id}")]
        public ActionResult<string> Delete (int ID)
        {
            var result = _productService.Delete(ID);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpPut("{id}")]
        public ActionResult<string> Update(int id,CarIM car)
        {
            
            var result = _productService.Update(id,car);
            
            return Ok(result);
        }
    }
}
