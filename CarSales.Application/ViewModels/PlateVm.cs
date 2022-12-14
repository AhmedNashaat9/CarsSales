using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.ViewModels
{
    public class PlateVm
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string FrontPlate { get; private set; }
        public string RearPlate { get; private set; }
    }
}
