using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"\b[a-zA-Z]([a-zA-Z0-9_]){2,25}\b";

            var matches = Regex.Matches(input, pattern);

            int longestLen = 0;
            Dictionary<string, string> usernames = new Dictionary<string, string>();
            for (int i = 1; i < matches.Count; i++)
            {

                int currLen = matches[i - 1].Length + matches[i].Length;
                if (currLen > longestLen)
                {
                    longestLen = currLen;
                    usernames.Clear();
                    usernames.Add(matches[i - 1].Value, matches[i].Value);
                }
            }

            Console.WriteLine(usernames.Keys.First());
            Console.WriteLine(usernames.Values.First());
        }
    }
}
