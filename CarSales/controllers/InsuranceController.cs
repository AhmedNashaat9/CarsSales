using CarSales.Application.InputModels;
using CarSales.Application.IServices;
using CarSales.Application.Services;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using Hangfire;
using Microsoft.AspNetCore.Mvc;

namespace CarSales.Api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceService _InsuranceService;

        public InsuranceController(IInsuranceService InsuranceService)
        {
            _InsuranceService = InsuranceService;

        }


        [HttpPost("Insurance")]

        public ActionResult<string> Create(InsuranceIM Insurance)
        {

            var Result = _InsuranceService.Create(Insurance);
           BackgroundJob.Schedule(() => updatevalid(Insurance.CarId),TimeSpan.FromMinutes(1));
            return Ok(Result);

        }
        [HttpGet("Isurancelist")]
        public ActionResult<List<InsuranceVM>> GetALL()
        {

            var result = _InsuranceService.GetAll();
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [HttpDelete("id")]
        public ActionResult<string> DeleteInsurance(int ID)
        {
            var result = _InsuranceService.Delete(ID);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        public void updatevalid(int id)
        {
            _InsuranceService.UpdateValid(id);
        }
        [HttpGet]
        public ActionResult<InsuranceVM> GetBycarId(int carid)
        {
            var result = _InsuranceService.GetByCarId(carid);


            return Ok(result);
        }

    }
}
