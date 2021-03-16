// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hp0 = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hp0.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hp0.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hp0.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hp0.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hp0.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hp0.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hp0.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hp0.Gender = Convert.ToString(Console.ReadLine());

        
        
        hp0.DisplayFirstName();
        hp0.DisplayLastName();
        hp0.DisplayDayOfBirth();
        hp0.DisplayMonthOfBirth();
        hp0.DisplayYearOfBirth();
        hp0.DisplayWeightInPounds();
        hp0.DisplayHeightInInches();
        hp0.DisplayGender();
        hp0.DisplayYearsOfAgeSimple();
        hp0.DisplayMaxHeartRate();
        hp0.DisplayTargetHeartRate();
        hp0.DisplayBodyMassIndex();
        hp0.DisplayBMIOutput();
        hp0.DisplayBMIChart();        
    }
}