using System;
using System.Text;

namespace ArraysAndStringsLib
{
    public class Exercises
    {
        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percentage = (double)score / outOf;
            return $"You got {score} out of {outOf}: {percentage:p1}";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            bool IsNumber = Double.TryParse(numString, out double number);
            if (IsNumber)
            {
                return number;
            }
            else
            {
                return -999;
            }
            
        }
        public static string ManipulateString(string input, int num)
        {
            string output = input.Trim().ToUpper();
            for (int i = 0; i < num; i++)
            {
                output += i.ToString();
            }            
            return output;
        }
    }
}
