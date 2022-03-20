using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
            {
                return true;
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = 0;
            for (int i = 0; i < vals.Length; i++)
            {

                { count++; }
            }
            if (count % 2 == 0)
            { return true; }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            { return true; }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            { return true; }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            
                
            double min = numbers.Min();
            double max = numbers.Max();  
            return min + max;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            { return str2.Length; }
            else if (str1.Length < str2.Length)
            { return str1.Length; }
            else { return str1.Length; }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Length == 0)
            {
                return 0;
            }
            try
            {
                return numbers.Sum(x => x);
            }
            catch (ArgumentNullException)
            { return 0; }


        }

        public int SumEvens(int[] numbers)
        {
            if (numbers==null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    sum += numbers[i];
                    
                }
                
            }
            return sum;
            //return numbers.Where(x => x%2 == 0).Sum();

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;

            }
            var oddNum = numbers.Sum();
            if (oddNum%2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
           
            if (number < 0 || number == 0)
            {
                return 0;
            }
            long countPosOdd = 0;
            for (int i = 0; i<number; i++)
            {
               if (i > 0 && i%2 != 0)
                { countPosOdd++; }
            }
            return countPosOdd;
        }
    }

    
}
