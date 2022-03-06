using Patient_Registration.LogicLayer.DTOs;
using Patient_Registration.LogicLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Registration
{
    public partial class PatientRegForm : Form
    {
        private readonly IAddNewPatientService _addNewPatientService;
        private readonly IRetrieveSortedData _retrieveSortedData;

        public PatientRegForm(IAddNewPatientService addNewPatientService, IRetrieveSortedData retrieveSortedData)
        {
            InitializeComponent();
            _addNewPatientService = addNewPatientService;
            _retrieveSortedData = retrieveSortedData;

        }
        private void Submit_button_Click(object sender, EventArgs e)
        {
            if (FirstName_textBox.Text != "" && LastName_textBox.Text != "" && Cardiac_Box.Text != "" && DHistory_Box.Text != "" && FeverBox.Text != "")
            {
                var Evaluator = new RiskEvaluator();
                var VoterDetails = new PatientDTO()
                {
                    Age = (int)Age_Box.Value,
                    FirstName = FirstName_textBox.Text,
                    LastName = LastName_textBox.Text,
                    BodyTemperature = (double)BodyTemp_Box.Value,
                    HeartRate = (double)HeartRate_box.Value,
                    HasCardiacRelatedConditions = Cardiac_Box.Text == "YES" ? true : false,
                    HasDiabeticHistory = DHistory_Box.Text == "YES" ? true : false,
                    HasFeverSymptoms = FeverBox.Text == "YES" ? true : false,
                    SymptomDays = (int)Symptom_Days_Box.Value

                };
                _addNewPatientService.AddNewPatient(VoterDetails, Evaluator);

                ClearFields();
                MessageBox.Show("Patient Added Successfully");
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
            


        }
        public void ClearFields()
        {
            Age_Box.Value = Age_Box.Minimum;
            FirstName_textBox.Text = "";
            LastName_textBox.Text = "";
            BodyTemp_Box.Value = BodyTemp_Box.Minimum;
            HeartRate_box.Value = HeartRate_box.Minimum;
            Symptom_Days_Box.Value = Symptom_Days_Box.Minimum;
            FeverBox.Text = "";
            DHistory_Box.Text = "";
            Cardiac_Box.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            var pageTwo = new PatientListForm(_retrieveSortedData);
            pageTwo.Show();
        }

        private void PatientRegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
