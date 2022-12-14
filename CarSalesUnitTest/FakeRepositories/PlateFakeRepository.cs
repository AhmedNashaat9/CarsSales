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

namespace CarSalesUnitTest.FakeRepositories
{
    public class PlateFakeRepository : IBaseRepository<Plate>
    {
        private readonly List<Plate> _plate;



        public PlateFakeRepository()
        {

            _plate = new List<Plate>()
            {
                new Plate()
                {
                    Id = 1,
                    CarId = 1,
                    FrontPlate="44dd",
                    RearPlate="44dd",
                },
                new Plate()
                {
                    Id = 2,
                    CarId = 2,
                    FrontPlate="44ss",
                    RearPlate="44ss",
                },
                new Plate()
                {
                    Id = 3,
                    CarId = 3,
                    FrontPlate="44nn",
                    RearPlate="44nn",
                },
                new Plate()
                {
                    Id = 4,
                    CarId = 4,
                    FrontPlate="44nn",
                    RearPlate="44nn",
                }
            };
        }


        string IBaseRepository<Plate>.Create(Plate entity)
        {
            _plate.Add(entity);
            return "ok";
        }

        string IBaseRepository<Plate>.Delete(Plate entity)
        {
            _plate.Remove(entity);
            return "deleted";
        }

        List<Plate> IBaseRepository<Plate>.GetAll()
        {
            return _plate.ToList();
        }

        Plate? IBaseRepository<Plate>.GetById(int entity)
        {
            return _plate.Where(c => c.Id == entity).FirstOrDefault();  
        }

        string IBaseRepository<Plate>.Update(Plate entity)
        {
            throw new NotImplementedException();
        }
    }
}
