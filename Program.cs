
//SIMRANJIT  KAUR
//200536453
//ASSIGNMENT 1
    using Csharp_Assignment_1;
using System;

namespace Csharp_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide your age:");
            int age = int.Parse(Console.ReadLine());

            // Prompt user to enter patient information
            Console.WriteLine("Please enter patient's information:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Weight (KG): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Height (CM): ");
            double height = double.Parse(Console.ReadLine());

            // Create a new patient object with the entered information
            Patient patient = new Patient(firstName, lastName, weight, height);

            // Output the patient's information and calculated values
            patient.OutputPatientInformation();

            Console.ReadLine();
        }
    }
}
