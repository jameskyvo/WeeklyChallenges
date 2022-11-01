using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null))
            {
                return false;
            }
            foreach(var item in words)
            {
                if (ignoreCase == true)
                {
                    if (item.Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        return true;
                    }
                }
                else
                {
                    if (String.Equals(item,word))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false ;
            }
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for(int i = 0; i < str.Length; i++)
            {
                uindex = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if (uindex)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        break;
                    }
                currentCount++;
                }
                    if (currentCount > count)
                    {
                    count = currentCount;
                    }  
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();
            double[] nullCheck = new double[0];
            if (elements == null || n < 1)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }
            }
            double[] finalArray = nthElement.ToArray();
            return finalArray;
        }
    }
}
