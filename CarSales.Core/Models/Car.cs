using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Core.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public Plate Plate { get; set; }
        public InsuranceContract InsuranceContract { get; set; }

    }
}
