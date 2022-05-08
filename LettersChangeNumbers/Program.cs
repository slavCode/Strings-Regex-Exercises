using System;
using System.Collections.Generic;
using System.Linq;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<char, decimal> alphabet = new Dictionary<char, decimal>();
            AddAlphabet(alphabet);

            string[] lines = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal sum = 0;
            foreach (string line in lines)
            {
                decimal num = decimal.Parse(line.Substring(1, line.Length - 2));

                char firstLetter = line[0];
                if (Char.IsUpper(firstLetter))
                {
                    sum += num / alphabet[Char.ToLower(firstLetter)];
                }
                else
                {
                    sum += num * alphabet[firstLetter];
                }

                char secondLetter = line[line.Length - 1];
                if (Char.IsUpper(secondLetter))
                {
                    sum -= alphabet[Char.ToLower(secondLetter)];
                }
                else
                {
                    sum += alphabet[secondLetter];
                }
            }
            Console.WriteLine($"{sum:F2}");
        }

        private static void AddAlphabet(Dictionary<char, decimal> alphabet)
        {
            alphabet.Add('a', 1);
            alphabet.Add('b', 2);
            alphabet.Add('c', 3);
            alphabet.Add('d', 4);
            alphabet.Add('e', 5);
            alphabet.Add('f', 6);
            alphabet.Add('g', 7);
            alphabet.Add('h', 8);
            alphabet.Add('i', 9);
            alphabet.Add('j', 10);
            alphabet.Add('k', 11);
            alphabet.Add('l', 12);
            alphabet.Add('m', 13);
            alphabet.Add('n', 14);
            alphabet.Add('o', 15);
            alphabet.Add('p', 16);
            alphabet.Add('q', 17);
            alphabet.Add('r', 18);
            alphabet.Add('s', 19);
            alphabet.Add('t', 20);
            alphabet.Add('u', 21);
            alphabet.Add('v', 22);
            alphabet.Add('w', 23);
            alphabet.Add('x', 24);
            alphabet.Add('y', 25);
            alphabet.Add('z', 26);
        }
    }
}
