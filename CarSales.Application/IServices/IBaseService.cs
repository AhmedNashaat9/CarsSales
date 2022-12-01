using CarSales.Application.InputModels;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.IServices
{
    public interface IBaseService
    {
        string Create(CarIM entity);
        string Delete(int ID );
        string Update(int id,CarIM entity);
        CarVM? GetById(int ID);
        List<CarVM> GetAll();
    }
}
