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
    public partial class PatientListForm : Form
    {
        private readonly IRetrieveSortedData _retrieveSortedData;
        public PatientListForm(IRetrieveSortedData retrieveSortedData)
        {
            InitializeComponent();
            _retrieveSortedData = retrieveSortedData;
        }

        private void PatientListForm_Load(object sender, EventArgs e)
        {
            var rangeAccepted = new[] { 15, 30, 45, 60, 75, 90, 100 };
            var lists = _retrieveSortedData.RetriveDataGroups().OrderByDescending(x =>
            x.Value);

            foreach (var item in lists)
            {
                var rangePointer = rangeAccepted.FirstOrDefault(x => item.Value > x);
                var rangeValueString = rangePointer < 15 ? "Less Than 15%" : $"Greater Than {rangePointer}%";
                dataGridView1.Rows.Add(rangeValueString, item.Key.FullName, item.Key.Id, item.Value+"%"); 
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
