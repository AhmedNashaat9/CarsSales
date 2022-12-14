using CarSales.Application.InputModels;
using CarSales.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.IServices
{
    public interface IPlateService
    {
        string Create(PlateIM entity);
        string Delete(int ID);
        PlateVm? GetById(int ID);
        List<PlateVm> GetAll();

    }
}
