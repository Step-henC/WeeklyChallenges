using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            if (numbers == null || numbers.Count() == 0)
            { 
                return false; 
            }
            int sum = numbers.Where(x => x % 2 != 0).Sum();
            if (sum % 2 != 0)
            { 
                return true; 
            }
            return false;
           
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNum = false;
            if (password == null || password.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]) )
                {
                    isUpper = true;
                }
                else if (char.IsLower(password[i]) )
                {
                    isLower = true;
                }
                else if (char.IsDigit(password[i]) )
                {
                    isNum = true;
                }
            }
            if (isLower == true && isNum == true && isUpper == true)
            {
                return true;
            }
            return false;
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
            try
            {
                return (dividend / divisor);
            }
            catch (DivideByZeroException)
            {
                return divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var nums = new List<int>();   
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums.Add(i);
                }
            }
            return nums.ToArray();
            
            
            
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
