using Hospital;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InsuredPatientTest
{
    [TestClass]
    public class InsuredPatientTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double baseCost = 50;
            double hoursInHospital = 1;
            double expected = (baseCost + hoursInHospital * 20)*0.9;

            //Act
            InsuredPatient patient = new InsuredPatient();
            double actual = patient.CalculateCost(hoursInHospital);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
