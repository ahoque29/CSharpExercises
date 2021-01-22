using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int i = 0;
            int highestNumber = nums[0];
            while (i < nums.Length)
            {
                if (highestNumber < nums[i])
                {
                    highestNumber = nums[i];
                }
                i++;
            }            
            return highestNumber;
        }
        
        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            int highestNumber = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (highestNumber < nums[i])
                {
                    highestNumber = nums[i];
                }
            }

            return highestNumber;
        }
        
        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            int highestNumber = int.MinValue;
            foreach (int i in nums)
            {
                if (highestNumber < i)
                {
                    highestNumber = i;
                }
            }
            return highestNumber;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            throw new NotImplementedException();
        }
    }
}