using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            bool isEven = (vals.Length % 2 == 0) ? true : false;
            return isEven;
        }

        public bool IsNumberEven(int number)
        {
            bool isEven = (number % 2 == 0) ? true : false;
            return isEven;
        }

        public bool IsNumberOdd(int num)
        {
            bool isEven = (num % 2 != 0) ? true : false;
            return isEven;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
                return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;

            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            foreach (int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            else if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var finalCount = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 != 0 && i != number)
                {
                    finalCount++;
                }
            }
            return finalCount;
        }
    }
}
