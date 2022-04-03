using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                if(numbers[i]%2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];  
                }
                
            }
            
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {   
            
            List<int> sorting = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            sorting.Sort();
           
            return sorting.Min();
            
               
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> nums = new List<int>() { number1, number2, number3, number4 };
            nums.Sort();
            return nums[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
           if (input == null)   
                return false;

            
            bool numStr = double.TryParse(input, out _);
            return numStr;
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int counter = 0;
            for(int i = 0; i<objs.Length; i++)
            {
                if(objs[i] == null)
                { counter++; }
            }
            if(counter >(objs.Length/2))
            { return true; }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {   
            double evenCount = 0;
            double sum = 0;    
            if (numbers == null || numbers.Length == 0)
            { return 0; }
           
            
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                        evenCount++;
                    }

                }
                if(evenCount == 0)
                     { return 0; }
                return Convert.ToDouble(sum/evenCount);
           
         
            
              
            
        }

        public int Factorial(int number)
        {
            try
            {   while (Factorial(number) < 1)
                {
                    return number * Factorial(number - 1);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            return 0;
           
        }
    }
}
