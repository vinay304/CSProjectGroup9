using System;

public class Patient
{
    // Private fields to store patient information
    private string firstName;
    private string lastName;
    private double weight; // Weight in kilograms
    private double height; // Height in centimeters

    // Public property for FirstName with get and set accessors
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    // Public property for LastName with get and set accessors
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    // Public property for Weight with get and set accessors
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    // Public property for Height with get and set accessors
    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    // Constructor to initialize a new Patient object with given details
    public Patient(string fname, string lname, double w, double h)
    {
        firstName = fname;
        lastName = lname;
        weight = w;
        height = h;
    }

    // Public method to evaluate blood pressure status based on systolic and diastolic values
    public string CheckBloodPressure(int systolic, int diastolic)
    {
        if (systolic < 120 && diastolic < 80)
        {
            return "NORMAL";
        }
        else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
        {
            return "ELEVATED";
        }
        else if ((systolic >= 130 && systolic <= 139) || (diastolic >= 80 && diastolic <= 89))
        {
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
        }
        else if ((systolic >= 140 && systolic <= 180) || (diastolic >= 90 && diastolic <= 120))
        {
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
        }
        else if (systolic > 180 || diastolic > 120)
        {
            return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
        }
        else
        {
            return "Invalid or unknown blood pressure readings.";
        }
    }

    // Private method to calculate BMI using weight and height
    private double CalculateBMI()
    {
        double heightInMeters = height / 100; // Convert height from cm to meters
        double bmi = weight / (heightInMeters * heightInMeters); // BMI formula
        return bmi;
    }

    // Public method to display full patient information including blood pressure and BMI status
    public void DisplayPatientInfo(int systolic, int diastolic)
    {
        Console.WriteLine("---------- Patient Report ----------");
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        Console.WriteLine("Weight: " + Weight + " kg");
        Console.WriteLine("Height: " + Height + " cm");

        // Get blood pressure status
        string bpStatus = CheckBloodPressure(systolic, diastolic);
        Console.WriteLine("Blood Pressure Result: " + bpStatus);

        // Calculate and display BMI value rounded to 2 decimal places
        double bmi = CalculateBMI();
        Console.WriteLine("BMI Value: " + Math.Round(bmi, 2));

        // Determine BMI status based on BMI value
        if (bmi >= 25.0)
        {
            Console.WriteLine("BMI Status: Overweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("BMI Status: Normal (In the healthy range)");
        }
        else
        {
            Console.WriteLine("BMI Status: Underweight");
        }
        Console.WriteLine("------------------------------------");
    }
}
