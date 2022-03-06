using Patient_Registration.LogicLayer.Persistence;
using Patient_Registration.LogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Registration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var patientRepo = new PatientRepository(new Data.Database());
            Application.Run(new PatientRegForm(new AddNewPatientService(patientRepo),new RetrieveSortedData(patientRepo)));
        }
    }
}
