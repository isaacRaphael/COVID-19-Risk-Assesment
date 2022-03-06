using Patient_Registration.LogicLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.Data
{
    public class Database
    {
        public Dictionary<IPatient , double> PatientTable { get; set; } = new Dictionary<IPatient ,double>();
    }

}
