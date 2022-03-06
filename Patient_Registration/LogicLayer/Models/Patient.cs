using Patient_Registration.LogicLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.LogicLayer.Models
{
    public class Patient : IPatient
    {
        public string Id { get; }
        public Patient()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5);
        }
        public Patient(string id)
        {
            Id = id;
        }
        public string FirstName {  get;  set; }
        public string LastName { get; set; }
        public string  FullName { get {
                return FirstName + " " + LastName;
            }}

        public int Age { get; set; }
        public double BodyTemperature { get; set; }
        public double HeartRate { get; set; }

        public bool HasCardiacRelatedConditions { get; set; }
        public bool HasDiabeticHistory { get; set; }
        public bool HasFeverSymptoms { get; set; }
        public int SymptomDays { get; set; }


        public override string ToString()
        {
            return $"Patiet Name : {FullName}, Patient Id :{Id}."; 
        }
    }
}
