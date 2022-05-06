using System;
using System.Linq;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main()
        {
            var tokkens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string firstStr = tokkens[0];
            string secondStr = tokkens[1];

            long len = Math.Min(firstStr.Length, secondStr.Length);
            long result = 0;
            for (int i = 0; i < len; i++)
            {
                result += firstStr[i] * secondStr[i];
            }

            if (firstStr.Length > secondStr.Length)
            {
                result = SumChars(firstStr, secondStr, result);
            }
            else if (firstStr.Length < secondStr.Length)
            {
                result = SumChars(secondStr, firstStr, result);
            }

            Console.WriteLine(result);
        }

        private static long SumChars(string longestStr, string shortestStr, long result)
        {
            
            for (int i = shortestStr.Length; i < longestStr.Length; i++)
            {
                result += longestStr[i];
            }

            return result;
        }
    }
}
