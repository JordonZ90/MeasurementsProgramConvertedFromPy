using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementsProgram
{
    public class ConversionMethods
    {
        public static double InchesToCentimeters(double inches)
        {
            double centimeters = inches * 2.54;
            return centimeters;
        }
        public static double CentimetersToInches(double centimeters)
        {
            double inches = centimeters / 2.54;
            return inches;
        }
        public static double FeetToYards(double feet)
        {
            double yards = feet / 3;
            return yards;
        }
        public static double YardsToFeet(double yards)
        {
            double feet = yards * 3;
            return feet;
        }
        public static double FeetToMiles(double feet)
        {
            double miles = feet / 5280;
            return miles;
        }
        public static double MilesToFeet(double miles)
        {
            double feet = miles * 5280;
            return feet;
        }
    }
}
