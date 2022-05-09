using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine().Trim();
            var lines = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = $@"(?<=\W){word}(?=\W)";

            foreach (var line in lines)
            {
                bool isMatch = Regex.IsMatch(line, pattern);
                if (isMatch)
                {
                    Console.WriteLine(line.Trim());
                }
            }
        }
    }
}
