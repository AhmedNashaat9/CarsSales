﻿using AutoMapper;
using CarSales.Application.InputModels;
using CarSales.Application.ViewModels;
using CarSales.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarVM>();
            CreateMap<CarIM, Car>();

        }
    }
}
