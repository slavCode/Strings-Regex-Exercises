using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MelrahShake
{
    internal class Program
    {
        static void Main()
        {
            //    string chars = Console.ReadLine();
            //    string pattern = Console.ReadLine();


            //    while (chars.Contains(pattern))
            //    {
            //        int occurancies = GetOccurancies(chars, pattern);
            //        if (occurancies > 1)
            //        {
            //            Console.WriteLine("Shaked it.");
            //            chars = chars.Replace(pattern, "");
            //            if (pattern.Length > 1)
            //            {
            //                int index = pattern.Length / 2;
            //                pattern = pattern.Remove(index, 1);
            //            }
            //            else
            //            {
            //                Console.WriteLine(chars);
            //                return;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("No shake.");
            //            chars = chars.Replace(pattern, "");
            //            Console.WriteLine(chars);
            //            return;
            //        }


            //    }

            //    Console.WriteLine("No shake.");
            //    Console.WriteLine(chars);
            //}

            //static int GetOccurancies(string str, string pattern)
            //{

            //    int occurancies = 0;
            //    var matches = Regex.Matches(str, pattern);
            //    foreach (Match m in Regex.Matches(str, pattern))
            //    {

            //        occurancies++;
            //    }

            //    return occurancies;


            string stringInput = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (stringInput.Length > 0 && pattern.Length > 0)
            {
                int firstIndex = stringInput.IndexOf(pattern);
                int lastIndex = stringInput.LastIndexOf(pattern);

                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex)
                {
                    Console.WriteLine("Shaked it.");

                    stringInput = stringInput.Remove(firstIndex, pattern.Length);
                    lastIndex = stringInput.LastIndexOf(pattern);
                    stringInput = stringInput.Remove(lastIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(stringInput);
        }
    }
}
