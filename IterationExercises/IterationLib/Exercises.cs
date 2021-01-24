using System;

namespace IterationLib
{
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int lowestNumber = int.MaxValue;
            if (nums.Length != 0)
            {
                lowestNumber = nums[0];
                foreach (int i in nums)
                {
                    if (lowestNumber > i)
                    {
                        lowestNumber = i;
                    }
                }
            }                       
            return lowestNumber;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int numberOfA = 0, numberOfB = 0, numberOfC = 0, numberOfD = 0;

            foreach (char character in input)
            {
                switch (character)
                {
                    case 'A':
                        numberOfA++;
                        break;
                    case 'B':
                        numberOfB++;
                        break;
                    case 'C':
                        numberOfC++;
                        break;
                    case 'D':
                        numberOfD++;
                        break;
                }
            }
            
            return $"A:{numberOfA} B:{numberOfB} C:{numberOfC} D:{numberOfD}";
        }
    }
}
