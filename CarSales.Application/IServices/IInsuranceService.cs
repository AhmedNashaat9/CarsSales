using CarSales.Application.InputModels;
using CarSales.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.IServices
{
    public interface IInsuranceService
    {
        string Create(InsuranceIM entity);
        string Delete(int ID);
        List<InsuranceVM> GetAll();
        InsuranceVM? GetByCarId(int carID);
        void UpdateValid(int carid);


    }
}
