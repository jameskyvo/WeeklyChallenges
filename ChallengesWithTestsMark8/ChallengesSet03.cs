using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if(val == false)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Any() == false)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool numberPresent = false;
            bool upperPresent = false;
            bool lowerPresent = false;

            foreach (char c in password)
            {
                if (Char.IsUpper(c) == true)
                {
                    upperPresent = true;
                }
                else if (Char.IsLower(c) == true)
                {
                    lowerPresent = true;
                }
                else if (Char.IsDigit(c) == true)
                {
                    numberPresent = true;
                }
            }
            return numberPresent && upperPresent && lowerPresent;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] nums = new int[50];
            int oddNumber = -1;
            for (int i = 0; i < 50; i++)
            {
                oddNumber += 2;
                nums[i] = oddNumber;
            }
            return nums;
        }
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string upperWord = words[i].ToUpper();
                words[i] = upperWord;
            }
        }
    }
}
