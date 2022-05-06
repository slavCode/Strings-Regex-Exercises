using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Base10ToBaseN_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().ToArray();

            BigInteger nBase = BigInteger.Parse(nums[0]);
            BigInteger num = BigInteger.Parse(nums[1]);

            if (nBase >= 2 && nBase <= 10)
            {
                var result = new StringBuilder();
                while (num > 0)
                {
                    BigInteger reminder = 0;
                    reminder = num % nBase;
                    num /= nBase;
                    result.Insert(0, reminder);
                }

                Console.WriteLine(result.ToString());
                return;
            }
            Console.WriteLine(0);
        }
    }
}
