using System;
using System.Linq;
using System.Text;

namespace ConvertFromBase10ToBase_N
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nBase = nums[0];
            int num = nums[1];

            var result = new StringBuilder();
            while (num > nBase)
            {
                int reminder = 0;
                reminder = num % nBase;
                num /= nBase;
                result.Insert(0, reminder);
            }
            result.Insert(0, num.ToString());

            Console.WriteLine(result.ToString());
        }
    }
}
