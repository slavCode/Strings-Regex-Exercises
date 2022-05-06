using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicExchangeableWords
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                        .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

            var leftStr = input[0].Trim().Distinct().ToList();
            var rightStr = input[1].Trim().Distinct().ToList();
            bool isExchangeable = true;
            if (leftStr.Count != rightStr.Count)
            {
                isExchangeable = false;
            }
            else
            {
                var map = new Dictionary<char, char>();
                for (int i = 0; i < leftStr.Count; i++)
                {
                    if (map.ContainsKey(leftStr[i]) && !map.ContainsValue(rightStr[i]))
                    {
                        isExchangeable = false;
                        break;
                    }
                    else
                    {
                        map.Add(leftStr[i], rightStr[i]);
                    }
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
