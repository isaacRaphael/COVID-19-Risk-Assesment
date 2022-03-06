using Patient_Registration.LogicLayer.Contracts;
using System.Collections.Generic;

namespace Patient_Registration.LogicLayer.Services
{
    public interface IRetrieveSortedData
    {
        Dictionary<IPatient, double> RetriveDataGroups();
    }
}