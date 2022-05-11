using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    internal class Program
    {
        static void Main()
        {
            
            string pattern = @"(?<=<p>).*?(?=<\/p>)";
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);
            string text = String.Empty;
            foreach (Match match in matches)
            {
                text += Regex.Replace(match.Value, @"[^a-z0-9]+", " ");
            }

            Dictionary<char, char> replacments = new Dictionary<char, char>();
            AddDecryption(replacments);
            StringBuilder result = new StringBuilder();
            foreach (var letter in text.ToCharArray())
            {
                if (Char.IsLetter(letter))
                {
                    result.Append(replacments[letter]);
                }
                else result.Append(letter);
            }

            Console.WriteLine(result.ToString());
        }

        static void AddDecryption(Dictionary<char, char> replacments)
        {
            replacments.Add('a', 'n');
            replacments.Add('b', 'o');
            replacments.Add('c', 'p');
            replacments.Add('d', 'q');
            replacments.Add('e', 'r');
            replacments.Add('f', 's');
            replacments.Add('g', 't');
            replacments.Add('h', 'u');
            replacments.Add('i', 'v');
            replacments.Add('j', 'w');
            replacments.Add('k', 'x');
            replacments.Add('l', 'y');
            replacments.Add('m', 'z');
            replacments.Add('n', 'a');
            replacments.Add('o', 'b');
            replacments.Add('p', 'c');
            replacments.Add('q', 'd');
            replacments.Add('r', 'e');
            replacments.Add('s', 'f');
            replacments.Add('t', 'g');
            replacments.Add('u', 'h');
            replacments.Add('v', 'i');
            replacments.Add('w', 'j');
            replacments.Add('x', 'k');
            replacments.Add('y', 'l');
            replacments.Add('z', 'm');
        }
    }
}
