using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var currentNumber = startNumber;
                do
                {
                    currentNumber++;
                }
                while (currentNumber % n != 0);
            return currentNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers?.Length == 0 || numbers == null)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var isEven = false;
            var sum = 0;
            if (numbers?.Length == 0 || numbers == null)
            {
                return 0;
            }
            foreach (var num in numbers)
            {
                if (isEven == true)
                {
                    sum += num;
                }
                if (num % 2 == 0)
                {
                    isEven = true;
                }
                else if (num % 2 != 0)
                {
                    isEven = false;
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var ignoredWords = 0;
            var includedWords = 0;
            var wordsList = new List<string>();
            if (words == null || words.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "" || words[i] == " " || words[i] == "  " || words[i] == "    ")
                {
                    ignoredWords += 1;
                }
                else
                {
                    wordsList.Add(words[i].Trim());
                    includedWords += 1;
                }
            }
            if (includedWords == 0)
            {
                return "";
            }
            else
            {
                return String.Join(" ", wordsList) + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            var everyFourthElement = new List<double>();
            foreach(var element in elements)
            {
                if (element % 4 == 0)
                {
                    everyFourthElement.Add(element);
                }
            }
           var solution = everyFourthElement.ToArray();

            return solution;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
