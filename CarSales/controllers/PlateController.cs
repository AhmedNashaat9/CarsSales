using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarSales.Api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlateController : ControllerBase
    {
        private readonly IPlateService _PlateService;
        public PlateController(IPlateService plateService)
        {
            _PlateService = plateService;
        }
        [HttpPost("Plate")]
        public ActionResult<string> Create(PlateIM plate)
        {
            return Ok(_PlateService.Create(plate));
        }
        [HttpGet("platelist")]
        public ActionResult<List<PlateVm>> GetALLPlates()
        {
            var result = _PlateService.GetAll();
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpGet("PlateId")]
        public ActionResult<CarVM> GetPlateById(int id)
        {
            var result = _PlateService.GetById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete("deleteplateid")]
        public ActionResult<string> Delete(int ID)
        {
            var result = _PlateService.Delete(ID);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
