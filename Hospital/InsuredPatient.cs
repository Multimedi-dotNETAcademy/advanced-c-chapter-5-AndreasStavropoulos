using Hospital.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class InsuredPatient : Patient
    {
        public override double CalculateCost(double hoursInHospital)
        {
            return base.CalculateCost(hoursInHospital)*0.9;
        }
    }
}
