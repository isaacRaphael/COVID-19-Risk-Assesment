using Patient_Registration.Data;
using Patient_Registration.LogicLayer.Contracts;
using Patient_Registration.LogicLayer.DTOs;
using Patient_Registration.LogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.LogicLayer.Persistence
{
    public class PatientRepository : IPatientRepository
    {
        private readonly Database _database;

        public PatientRepository(Database database)
        {
            _database = database;
        }
        public Patient AddPatient(Patient entity, double patientRisk)
        {
            
           
            _database.PatientTable.Add(entity,patientRisk);

            return new Patient(entity.Id) {
                Age = entity.Age,
                BodyTemperature = entity.BodyTemperature,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                HeartRate = entity.HeartRate,
                HasCardiacRelatedConditions = entity.HasCardiacRelatedConditions,
                HasDiabeticHistory = entity.HasDiabeticHistory,
                HasFeverSymptoms = entity.HasFeverSymptoms,
                SymptomDays = entity.SymptomDays
            };

        }

        public Dictionary<IPatient, double> GetAllPatients()
        {
            var RetrievedPatientList = new Dictionary<IPatient, double>();
            
            foreach (var item in _database.PatientTable)
            {
                var copyPatient = new Patient(item.Key.Id)
                {
                    Age = item.Key.Age,
                    BodyTemperature = item.Key.BodyTemperature,
                    FirstName = item.Key.FirstName,
                    LastName = item.Key.LastName,
                    HeartRate = item.Key.HeartRate,
                    HasCardiacRelatedConditions = item.Key.HasCardiacRelatedConditions,
                    HasDiabeticHistory = item.Key.HasDiabeticHistory,
                    HasFeverSymptoms = item.Key.HasFeverSymptoms,
                    SymptomDays = item.Key.SymptomDays
                };
                RetrievedPatientList.Add(copyPatient, item.Value);

            }

            return RetrievedPatientList;
        }

        public Patient GetPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
