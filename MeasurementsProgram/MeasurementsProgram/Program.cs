using System;

namespace MeasurementsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            ConvertMeasurements();
        }
        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Inches to Centimeters");
            Console.WriteLine("2. Centimeters to inches");
            Console.WriteLine("3. Feet to Yards");
            Console.WriteLine("4.Yards to Feet");
            Console.WriteLine("5. Feet to Miles");
            Console.WriteLine("6. Miles to Feet");
            Console.WriteLine("");
        }

        public static void ConvertMeasurements()
        {
            string again = "y";

            while (again == "y".ToLower())
            {
                Console.WriteLine("Enter a menu option ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Enter measurement in inches ");
                    double inches = double.Parse(Console.ReadLine());
                    double centimeters = ConversionMethods.InchesToCentimeters(inches);
                    centimeters = Math.Round(centimeters, 2);
                    Console.WriteLine($"Measurement in inches {inches} converted to {centimeters} centimeters");
                }
                else if (option == "2")
                {
                    Console.WriteLine("Enter measurement in centimeters ");
                    double centimeters = double.Parse(Console.ReadLine());
                    double inches = ConversionMethods.CentimetersToInches(centimeters);
                    inches = Math.Round(inches, 2);
                    Console.WriteLine($"Measurement in centimeters {centimeters} converted to {inches} inches");
                }
                else if (option == "3")
                {
                    Console.WriteLine("Enter measurement in feet ");
                    double feet = double.Parse(Console.ReadLine());
                    double yards = ConversionMethods.FeetToYards(feet);
                    yards = Math.Round(yards, 2);
                    Console.WriteLine($"Measurement in feet {feet} converted to {yards} yards");
                }
                else if (option == "4")
                {
                    Console.WriteLine("Enter measurement in yards ");
                    double yards = double.Parse(Console.ReadLine());
                    double feet = ConversionMethods.YardsToFeet(yards);
                    feet = Math.Round(feet, 2);
                    Console.WriteLine($"Measurement in yards {yards} converted to {feet} feet");
                }
                else if (option == "5")
                {
                    Console.WriteLine("Enter measurement in feet ");
                    double feet = double.Parse(Console.ReadLine());
                    double miles = ConversionMethods.FeetToMiles(feet);
                    miles = Math.Round(miles, 2);
                    Console.WriteLine($"Measurement in feet {feet} converted to {miles} miles");
                }
                else if (option == "6")
                {
                    Console.WriteLine("Enter measurement in miles ");
                    double miles = double.Parse(Console.ReadLine());
                    double feet = ConversionMethods.MilesToFeet(miles);
                    feet = Math.Round(feet, 2);
                    Console.WriteLine($"Measurement in miles {miles} converted to {feet} feet");
                }
                else
                {
                    Console.WriteLine("You must enter a valid number");
                }

                Console.WriteLine("Convert another measurement? (y|n)");
                again = Console.ReadLine();
                if (again == "y")
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
