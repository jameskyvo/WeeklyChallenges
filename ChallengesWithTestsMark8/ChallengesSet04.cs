using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var total = 0;
            foreach (var number in numbers)
            {
                if(number % 2 == 0)
                {
                    total += number;
                }
                else
                {
                    total -= number;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[] { str1, str2, str3, str4 };
            var shortestStringLength = str1.Length;
            foreach (var words in strings)
            {
                if (words.Length < shortestStringLength)
                {
                    shortestStringLength = words.Length;
                }
            }
            return shortestStringLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new int[] { number1, number2, number3, number4 };
            var smallestNumber = number1;
            foreach (var num in numbers)
            {
                if (num < smallestNumber)
                {
                    smallestNumber = num;
                }
            }
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideA, int sideB, int sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideC + sideB > sideA)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            double number;
            var result = double.TryParse(input, out number);
            return result;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
