using System;
using System.Text;

namespace UnicodeCharacters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
                sb.AppendFormat("\\u{0:x4}", (int)c);

            Console.WriteLine(sb);
        }
    }
}
