using AutoMapper;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using CarSales.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using SalesCore.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesUnitTest.FakeRepositories
{
    public class CarFakeRepository : IBaseRepository<Car>
    {
       private readonly List<Car> _car;

        

        public CarFakeRepository()
        {

            _car = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    Name = "x6",
                    Price = 320,
                    Type = "BMW",
                    Color = "black",
                    
                }
                ,new Car()
                {
                    Id=2,Name="AMG",Price=320,Type="mercedes",Color="black"
                }
                ,new Car()
                {
                    Id=3,Name="MG5",Price=320,Type="MG",Color="red"
                }
                ,new Car()
                {
                    Id=4,Name="hs",Price=320,Type="MG",Color="blue"
                }
                ,new Car()
                {
                    Id=5,Name="GrandTerios",Price=320,Type="Daihatsu",Color="black"
                }
                ,new Car()
                {
                    Id=6,Name="A8",Price=320,Type="Skoda",Color="blue"
                }
                ,new Car()
                {
                    Id=7,Name="x5",Price=320,Type="BMW",Color="white"
                }
                ,new Car(){
                    Id=8,Name="x7",Price=320,Type="MG",Color="black"
                }
            };
        }
        public string Create(Car entity)
        {
            _car.Add(entity);
            return "ok";
        }

        public string Delete(Car entity)
        {
            _car.Remove(entity);
            return "deleted";
        }

        public List<Car> GetAll()
        {
            return _car.ToList();
        }

        public Car? GetById(int entity)
        {
            return _car.Where( c=>c.Id==entity).FirstOrDefault();
        }

       

        public string Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
