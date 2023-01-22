using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var alpha = "abcdefghijklmnopqrstuvwxyz";
            return alpha.Contains(char.ToLower(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;

            }
        }

        public int Sum(int[] numbers)
        {
           
            return (numbers == null) ? 0 : numbers.Sum();
          
        }

        public int SumEvens(int[] numbers)
        {
           if (numbers == null)
           {
                return 0;
           }

            var evenSum = 0;

           for (int i = 0; i < numbers.Length; i++) 
           { 
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
           }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers == null) ? false : numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }

        }
    }
}
