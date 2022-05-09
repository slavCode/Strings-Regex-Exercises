using System;
using System.Text.RegularExpressions;

namespace ExtractЕmails
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-_]+\.[a-z][a-z\.]+[a-z]?\b";
            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
