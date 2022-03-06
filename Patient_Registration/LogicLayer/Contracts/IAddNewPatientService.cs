using Patient_Registration.LogicLayer.Contracts;
using Patient_Registration.LogicLayer.DTOs;
using Patient_Registration.LogicLayer.Models;

namespace Patient_Registration.LogicLayer.Services
{
    public interface IAddNewPatientService
    {
        Patient AddNewPatient(PatientDTO model, IRiskEvaluator riskEvaluator);
    }
}