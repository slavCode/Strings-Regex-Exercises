using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QueryMess
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string replaced = ReplaceEncoded(input);
                var pairs = replaced.Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(t => t.Trim()).ToArray();
                var dataDict = new Dictionary<string, string>();

                foreach (var pair in pairs)
                {
                    string key = pair.Split('=')[0].Trim();
                    int keyIdx = key.LastIndexOf('?');
                    if (keyIdx > -1) key = key.Remove(0, keyIdx + 1);

                    string value = pair.Split('=')[1].Trim();
                    int valueIdx = value.IndexOf('?');
                    if (valueIdx > -1) value = value.Remove(valueIdx);

                    if (dataDict.ContainsKey(key))
                    {
                        if (!dataDict[key].Contains(value))
                        {
                            dataDict[key] += ", " + value;
                        }
                        else dataDict[key] = value;
                    }
                    else dataDict.Add(key, value);
                }

                foreach (var pair in dataDict)
                {
                    Console.Write($"{pair.Key}=[{pair.Value}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }

        static string ReplaceEncoded(string input)
        {
            string pattern = @"(\+|%20)+";

            return Regex.Replace(input, pattern, " ");
        }
    }
}
