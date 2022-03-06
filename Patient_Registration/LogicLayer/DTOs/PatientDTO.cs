using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.LogicLayer.DTOs
{
    public class PatientDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double BodyTemperature { get; set; }
        public double HeartRate { get; set; }
        public bool HasCardiacRelatedConditions { get; set; }
        public bool HasDiabeticHistory { get; set; }
        public bool HasFeverSymptoms { get; set; }
        public int SymptomDays { get; set; }
    }
}
