using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_Registration.LogicLayer.Contracts;
using Patient_Registration.LogicLayer.Persistence;

namespace Patient_Registration.LogicLayer.Services
{
    public class RetrieveSortedData : IRetrieveSortedData
    {
        private readonly IPatientRepository _patientRepository;
        public RetrieveSortedData(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public Dictionary<IPatient , double> RetriveDataGroups()
        {
            //var AcceptedRange = new[] { 15, 30, 45, 60, 75, 100 };
            //var query = _patientRepository.GetAllPatients().GroupBy(x =>
            //    AcceptedRange.FirstOrDefault(r => x.Value > r)
            //);

            //foreach (var list in query)
            //{
            //    list.OrderByDescending(x => x.Value);
            //}

            var query = _patientRepository.GetAllPatients();

            return query;
        }
    }
}
