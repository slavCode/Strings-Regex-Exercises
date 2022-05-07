using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            string secondNumber = Console.ReadLine();
            if (secondNumber == "0")
            {
                Console.WriteLine("0");
                return;
            }

            var resultsToSum = new List<string>();
            int mindNumber = 0;
            int zeroCounter = 0;

            var stringsSortedByLongestLength = GetStringsFirstWithLongestLength(firstNumber, secondNumber);
            string longestStr = stringsSortedByLongestLength[1];
            string shortStr = stringsSortedByLongestLength[0];

            for (int i = longestStr.Length - 1; i >= 0; i--)
            {
                int firstDigit = int.Parse(longestStr[i].ToString());
                var currResult = new StringBuilder();
                for (int j = shortStr.Length - 1; j >= 0; j--)
                {
                    int currDigit = int.Parse(shortStr[j].ToString());
                    string sumStr = (firstDigit * currDigit + mindNumber).ToString();
                    if (sumStr.Length > 1)
                    {
                        currResult.Insert(0, sumStr[1]);
                        mindNumber = int.Parse(sumStr[0].ToString());
                    }
                    else
                    {
                        currResult.Insert(0, sumStr);
                        mindNumber = 0;
                    }
                }

                string zeros = new string('0', zeroCounter);
                string resultWithZeros = currResult.ToString() + zeros;
                if (mindNumber != 0)
                {
                    resultWithZeros = mindNumber.ToString() + resultWithZeros;
                }
                resultsToSum.Add(resultWithZeros);
                zeroCounter++;
            }

            if (resultsToSum.Count == 1)
            {
                Console.WriteLine(resultsToSum[0]);
            }
            else
            {
                var sum = new StringBuilder();
                var currSum = new StringBuilder().Append(resultsToSum[0]);

                for (int i = 1; i < resultsToSum.Count; i++)
                {
                    string firstNumbers = currSum.ToString();
                    string secondNumbers = resultsToSum[i];
                    currSum.Clear();

                    int maxLen = Math.Max(firstNumbers.Length, secondNumbers.Length);
                    firstNumbers = firstNumbers.PadLeft(maxLen, '0');
                    secondNumbers = secondNumbers.PadLeft(maxLen, '0');

                    int currMindNumber = 0;

                    for (int j = firstNumbers.Length - 1; j >= 0; j--)
                    {
                        int digitSum = int.Parse(firstNumbers[j].ToString()) + int.Parse(secondNumbers[j].ToString()) + currMindNumber;
                        currMindNumber = 0;
                        if (digitSum > 9)
                        {
                            digitSum -= 10;
                            currMindNumber++;
                            if (i == 0)
                            {
                                currSum.Insert(0, digitSum);
                                currSum.Insert(0, "1");
                                break;
                            }
                        }

                        currSum.Insert(0, digitSum);
                    }
                    sum.Clear();
                    sum.Append(currSum.ToString());

                }
            }
        }

        private static string[] GetStringsFirstWithLongestLength(string firstNumber, string secondNumber)
        {
            string[] strings = new string[2];
            if (firstNumber.Length > secondNumber.Length)
            {
                strings[0] = firstNumber;
                strings[1] = secondNumber;
            }
            else
            {
                strings[0] = secondNumber;
                strings[1] = firstNumber;
            }

            return strings;
        }
    }
}
