using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int HoursInHospital { get; set; }

        public virtual double CalculateCost(double hoursInHospital)
        {
            double baseCost = 50;
            double cost = baseCost + (20 * hoursInHospital);
            return cost;
        }

        public string ShowPatientInfo(int patientId)
        {
            return $"Name:{PatientName} Hours in Hospital: {HoursInHospital} Cost{CalculateCost(HoursInHospital)}";
        }
    }
}
