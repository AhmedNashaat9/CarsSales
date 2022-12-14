using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales.Application.ViewModels
{
    public class InsuranceVM
    {
        public Guid InsuranceNumber { get; set; } = Guid.NewGuid();
        public string InsuranceName { get; set; }
        public DateTime InsuranceDate { get; set; } = DateTime.Now;
        public int InsuranceAmount { get; set; }
        public bool IsValid { get; set; } = true;
        public int CarId { get; set; }
    }
}
