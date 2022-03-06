using Patient_Registration.LogicLayer.Models;
using Patient_Registration.LogicLayer.Services;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Patient patient = new Patient()
            {
                Age = 42,
                BodyTemperature = 39,
                HasDiabeticHistory = false,
                HasCardiacRelatedConditions = true,
                FirstName = "Emeka",
                LastName = "Ewelike",
                HeartRate = 107,
                HasFeverSymptoms = true,
                SymptomDays = 7
            };

            RiskEvaluator riskeval = new RiskEvaluator();
            //Act
            var actual = riskeval.CalculatePatientRisk(patient) * 100;
            var expected = 36;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
