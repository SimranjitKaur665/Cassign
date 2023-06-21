using System;

namespace Csharp_Assignment_1
{
    public class Patient
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } // in KG
        public double Height { get; set; } // in Centimeters

        // Custom constructor
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        // Method to calculate BMI
        public double CalculateBMI()
        {
            double heightInMeters = Height / 100; // Convert height from centimeters to meters
            return Weight / (heightInMeters * heightInMeters);
        }

        // Method to calculate blood pressure
        public static string CalculateBloodPressure(int systolic, int diastolic)
        {
            if (systolic < 0 || diastolic < 0)
            {
                return "Invalid blood pressure values";
            }

            if (systolic < 120 && diastolic < 80)
            {
                return "NORMAL";
            }
            else if (systolic < 130 && diastolic < 80)
            {
                return "ELEVATED";
            }
            else if (systolic < 140 || diastolic < 90)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            }
            else if (systolic < 180 || diastolic < 120)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            }
            else if (systolic >= 180 || diastolic >= 120)
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            }
            else
            {
                return "Blood pressure values not in range";
            }
        }

        // Method to output patient information
        public void OutputPatientInformation()
        {
            double bmi = CalculateBMI();
            string bmiStatus = "";

            if (bmi >= 25.0)
            {
                bmiStatus = "Overweight";
            }
            else if (bmi >= 18.5 && bmi < 25.0)
            {
                bmiStatus = "Normal (In the healthy range)";
            }
            else
            {
                bmiStatus = "Underweight";
            }

            Console.WriteLine("Patient Information:");
            Console.WriteLine("Full Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Weight: {0} KG", Weight);
            Console.WriteLine("Height: {0} CM", Height);
            Console.WriteLine("Blood Pressure: {0}", CalculateBloodPressure(120,80));
            Console.WriteLine("BMI: {0}", bmi);
            Console.WriteLine("BMI Status: {0}", bmiStatus);
        }
    }
}
