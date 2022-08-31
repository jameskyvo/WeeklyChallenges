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
            int count = 0;
            int total = 0;
            foreach(object obj in objs)
            {
                if(obj == null)
                {
                    count++;
                    total++;
                }
                else
                {
                    total++;
                }
            }
            if (count > (total / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else 
            {
                double sum = 0;
                double numOfEvens = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                        numOfEvens++;
                    }
                }
                if (numOfEvens > 0)
                {
                    return sum / numOfEvens;
                }
                else 
                { 
                    return 0; 
                }
            }
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = number - 1; i > 0; i--)
                {
                    number *= i;
                }
                return number;
            }
        }
    }
}
