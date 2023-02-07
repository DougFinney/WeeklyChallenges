using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            
            foreach(var num in numbers) 
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new List<string>() { str1, str2, str3, str4}.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new List<int>() { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return
                (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
                );
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (objs.Length / 2) + 1;

            var count = 0;

            foreach ( var obj in objs )
            {
                if (obj == null)
                {
                    count ++;
                }
            }
            return count >= majority;
        }

        public double AverageEvens(int[] numbers)
        {
            return (numbers?.Where(x => x % 2 == 0).Count() > 0) ? numbers.Where(x => x % 2 == 0).Average() : 0;
        }

        public int Factorial(int number) //4! = 4 * 3 * 2 * 1 = 24
        {
            var fact = 1;

            if (number < 0) 
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = number; i > 0; i--) 
            {
                fact *= i;
            }

            return fact;
        }
    }
}
