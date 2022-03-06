using Patient_Registration.LogicLayer.Contracts;
using Patient_Registration.LogicLayer.DTOs;
using Patient_Registration.LogicLayer.Models;
using System.Collections.Generic;

namespace Patient_Registration.LogicLayer.Persistence
{
    public interface IPatientRepository
    {

        Patient AddPatient(Patient entity, double risk);
        Patient GetPatient(Patient patient);
        Dictionary<IPatient, double> GetAllPatients();
    }
}