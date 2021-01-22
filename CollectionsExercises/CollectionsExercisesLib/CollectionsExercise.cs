using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            List<string> outputList = new List<string>();

            if (num > queue.Count)
            {
                num = queue.Count;
            }

            for (int i = 1; i <= num; i++)
            {
                outputList.Add(queue.Peek());
                queue.Dequeue();
            }

            string output = String.Join(", ", outputList);

            return output;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < original.Length; i++)
            {
                stack.Push(original[i]);
            }
            int[] outputArray = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                outputArray[i] = stack.Pop();
            }            
            return outputArray;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            char[] charArray = input.ToCharArray();
            List<string> onlyNumericList = new List<string>();
            foreach (char ch in charArray)
            {
                if (Char.IsNumber(ch))
                {
                    onlyNumericList.Add(ch.ToString());
                }
            }
            string inputOnlyNumeric = String.Join("", onlyNumericList);

            var countDict = new Dictionary<char, int>();
            foreach (var item in inputOnlyNumeric)
            {
                if (countDict.ContainsKey(item))
                {
                    countDict[item]++;
                }
                else 
                {
                    countDict.Add(item, 1);
                }
            }
            string output = "";
            foreach (var entry in countDict)
            {
                output += entry;
            }

            return output;
        }
    }
}
