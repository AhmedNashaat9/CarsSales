using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarSales.Core.Models
{
    public class Plate
    {
        public int Id { get; set; }
        public string FrontPlate { get ; set; } 
        public string RearPlate { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        //public void SetPlate(string platnumber)
        //{
        //    FrontPlate = platnumber;
        //    RearPlate = platnumber;
        //}

    }
}
