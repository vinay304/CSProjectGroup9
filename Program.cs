using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- Patient Health Record System -----");

        // Prompt user for patient's first name and read input
        Console.Write("Enter First Name: ");
        string fname = Console.ReadLine();

        // Prompt user for patient's last name and read input
        Console.Write("Enter Last Name: ");
        string lname = Console.ReadLine();

        // Prompt user for patient's weight in kilograms and convert input to double
        Console.Write("Enter Weight (in kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Prompt user for patient's height in centimeters and convert input to double
        Console.Write("Enter Height (in cm): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt user for systolic blood pressure and convert input to integer
        Console.Write("Enter Systolic Blood Pressure (upper value): ");
        int systolic = Convert.ToInt32(Console.ReadLine());

        // Prompt user for diastolic blood pressure and convert input to integer
        Console.Write("Enter Diastolic Blood Pressure (lower value): ");
        int diastolic = Convert.ToInt32(Console.ReadLine());

        // Create a new Patient object using the provided inputs
        Patient myPatient = new Patient(fname, lname, weight, height);

        Console.WriteLine("\nGenerating Report...\n");

        // Call method to display all patient information and health status
        myPatient.DisplayPatientInfo(systolic, diastolic);

        // Wait for user input before closing the program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
