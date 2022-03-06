using Patient_Registration.LogicLayer.Contracts;
using Patient_Registration.LogicLayer.DTOs;
using Patient_Registration.LogicLayer.Models;
using Patient_Registration.LogicLayer.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.LogicLayer.Services
{
    public class AddNewPatientService : IAddNewPatientService
    {

        private readonly IPatientRepository _patientRepository;
        public AddNewPatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Patient AddNewPatient (PatientDTO model, IRiskEvaluator riskEvaluator)
        {
            var NewPatient = new Patient()
            {
                Age = model.Age,
                BodyTemperature = model.BodyTemperature,
                FirstName = model.FirstName,
                LastName = model.LastName,
                HeartRate = model.HeartRate,
                HasCardiacRelatedConditions = model.HasCardiacRelatedConditions,
                HasDiabeticHistory = model.HasDiabeticHistory,
                HasFeverSymptoms = model.HasFeverSymptoms,
                SymptomDays = model.SymptomDays
            };
            var x = _patientRepository.AddPatient(NewPatient, riskEvaluator.CalculatePatientRisk(NewPatient) * 100);

            return x;
        }
    }
}
