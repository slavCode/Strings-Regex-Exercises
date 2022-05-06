using System;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    internal class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int maxLen = Math.Max(firstNumber.Length, secondNumber.Length);
            firstNumber = firstNumber.PadLeft(maxLen, '0');
            secondNumber = secondNumber.PadLeft(maxLen, '0');

            var sum = new StringBuilder();
            int mindNumber = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int digitSum = int.Parse(firstNumber[i].ToString()) + int.Parse(secondNumber[i].ToString()) + mindNumber;
                mindNumber = 0;
                if (digitSum > 9)
                {
                    digitSum -= 10;
                    mindNumber++;
                    if (i == 0)
                    {
                        sum.Append(digitSum);
                        sum.Append("1");
                        break;
                    }
                }

                sum.Append(digitSum);
            }
            var result = new string(sum.ToString().Reverse().SkipWhile(x => x == '0').ToArray());
            Console.WriteLine(result);






            //var firstLine = Console.ReadLine().TrimStart('0').ToCharArray();
            //var secondLine = Console.ReadLine().TrimStart('0').ToCharArray();
            //Array.Reverse(firstLine);
            //Array.Reverse(secondLine);

            //StringBuilder sb = new StringBuilder();
            //int reminder = 0;
            //long len = Math.Min(firstLine.Length, secondLine.Length);
            //for (long i = 0; i < len; i++)
            //{
            //    int firstNum = int.Parse(firstLine[i].ToString());
            //    int secondNum = int.Parse(secondLine[i].ToString());
            //    int sum = firstNum + secondNum + reminder;
            //    string digit = sum.ToString();
            //    if (digit.Length > 1)
            //    {
            //        reminder = 1;
            //        string lastDigit = digit[digit.Length - 1].ToString();
            //        sb.Insert(0, lastDigit);
            //    }
            //    else
            //    {
            //        reminder = 0;
            //        sb.Insert(0, digit);
            //    }
            //}

            //if (firstLine.Length > secondLine.Length)
            //{
            //    for (long i = len; i < firstLine.Length; i++)
            //    {
            //        int sum = int.Parse(firstLine[i].ToString()) + reminder;
            //        string sumStr = sum.ToString();
            //        if (sumStr.Length > 1)
            //        {
            //            reminder = 1;
            //            string lastDigit = sumStr[sumStr.Length - 1].ToString();
            //            sb.Insert(0, lastDigit);
            //        }
            //        else
            //        {
            //            reminder = 0;
            //            sb.Insert(0, sumStr);
            //        }
            //    }
            //}
            //else if (secondLine.Length > firstLine.Length)
            //{
            //    for (long i = len; i < secondLine.Length; i++)
            //    {
            //        int sum = int.Parse(secondLine[i].ToString()) + reminder;
            //        string sumStr = sum.ToString();
            //        if (sumStr.Length > 1)
            //        {
            //            reminder = 1;
            //            string lastDigit = sumStr[sumStr.Length - 1].ToString();
            //            sb.Insert(0, lastDigit);
            //        }
            //        else
            //        {
            //            reminder = 0;
            //            sb.Insert(0, sumStr);
            //        }
            //    }
            //}

            //if (reminder == 1)
            //{
            //    sb.Insert(0, 1);
            //}

            //Console.WriteLine(sb.ToString());
        }
    }
}
