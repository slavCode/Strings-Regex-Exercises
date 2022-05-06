using System;
using System.Linq;
using System.Numerics;

namespace ConvertFromBaseNToBase10
{
    internal class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int numLength = nums[1].Length;

            int nBase = int.Parse(nums[0]);
            var num = nums[1].ToCharArray();
            Array.Reverse(num);

            BigInteger result = new BigInteger();
            if (nBase >= 2 && nBase <= 10)
            {
                for (int i = 0; i < numLength; i++)
                {
                    int currDigit = int.Parse(num[i].ToString());
                    BigInteger currMultiplier = BigInteger.Pow(nBase, i);
                    result += currMultiplier * currDigit;
                }
                Console.WriteLine(result);
                return;
            }
            Console.WriteLine(0);
        }
    }
}
