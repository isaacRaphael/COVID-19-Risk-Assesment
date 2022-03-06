using Patient_Registration.LogicLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration.LogicLayer.Services
{
    public class RiskEvaluator : IRiskEvaluator
    {
        public double CalculatePatientRisk(IPatient patient)
        {
            var Risk = 0.01;

            //Calculating Temp Risk
            var TempRisk  = CalculateTempRisk(patient, Risk);
            //Calculating HeartRateRisk
            var HeartRateRisk = CalculateHearRateRisk(patient, Risk);

            Risk = Risk + TempRisk + HeartRateRisk;

            //other risk cases
            if (patient.Age > 40 && patient.HasCardiacRelatedConditions  == true)
            {
                Risk += 0.07;
            }
 
            if (patient.HasDiabeticHistory == true)
            {
                Risk += 0.12;
            }

            if(patient.HasFeverSymptoms == true  && patient.SymptomDays > 2)
            {
                Risk += 0.15;
            }
                

            return  Risk;
        }

        public static double CalculateTempRisk(IPatient patient, double risk)
        {
            var standard = 38;

            if (patient.BodyTemperature > standard)
            {
                var multiplier = 5 * (patient.BodyTemperature - standard);
                risk *= multiplier;
                return risk;
            }
            return 0;
        }
        public static double CalculateHearRateRisk(IPatient patient, double risk)
        {
            var standard = 85;

            
                var bpmDifference = standard - patient.HeartRate;
                {
                    if (bpmDifference < 0)
                    {
                        bpmDifference *= -1;

                        if (bpmDifference % 5 == 0)
                        {
                            var multiplier = (bpmDifference / 5) * 2;
                            risk *= multiplier;
                        } else
                        {
                        var multiplierDifferene = (bpmDifference / 5);
                        int Multiplier = (int)multiplierDifferene * 2;
                        risk *= (double)Multiplier;
                        }

                    }
                    else if (bpmDifference == 0)
                        {
                            return 0;
                        }
                    else
                        {
                            if (bpmDifference % 5 == 0)
                            {
                                var multiplier = (bpmDifference / 5) * 2;
                                risk *= multiplier;
                            }
                            else
                            {
                                var multiplierDifferene = (bpmDifference / 5);
                                int Multiplier = (int)multiplierDifferene * 2;
                                risk *= (double)Multiplier;
                            }
                        }
                }
            
            return risk;
        }
    }
}
