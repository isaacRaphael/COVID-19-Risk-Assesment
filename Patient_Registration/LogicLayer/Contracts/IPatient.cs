using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.LogicLayer.Contracts
{
    public interface IPatient
    {
        string Id { get; }
        int Age { get; set; }
        double BodyTemperature { get; set; }
        string FirstName { get;  set; }
        string FullName { get; }
        bool HasCardiacRelatedConditions { get; set; }
        bool HasDiabeticHistory { get; set; }
        bool HasFeverSymptoms { get; set; }
        double HeartRate { get; set; }
        string LastName { get; set; }
        int SymptomDays { get; set; }

        string ToString();
    }
}
