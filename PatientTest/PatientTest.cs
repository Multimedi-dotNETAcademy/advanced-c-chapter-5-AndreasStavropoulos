using Hospital.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace PatientTest
{
    [TestClass]
    public class PatientTest
    {
        [TestMethod]
        public void CalculateCostIsAccurate()
        {
            //Arrange
            double baseCost = 50;
            double hoursInHospital = 1;
            double expected = baseCost + hoursInHospital*20;

            //Act
            Patient patient = new Patient();
            double actual = patient.CalculateCost(hoursInHospital);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ShowInfoWorking()
        {
            //Arrange 
            Patient patient = new Patient();
            patient.PatientName = "Andreas";
            patient.HoursInHospital = 1;
            patient.PatientId = 1;
            
            string expected = $"Name:Andreas Hours in Hospital: 1 Cost{patient.CalculateCost(1)}";

            //Act
            string actual = patient.ShowPatientInfo(1);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
