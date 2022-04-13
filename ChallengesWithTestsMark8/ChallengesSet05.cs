using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
           
            for(int i = startNumber+1; i <= (startNumber+n); i++)
            {
                
              
                    if(i%n == 0)
                { return i; }   
            }
            return 1;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i =0; i<businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
        
            if(numbers == null || numbers.Length == 0 )
            { 
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
          
   
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 )
            {
                return 0;
            }
            int sum = 0;    
            for(int i=0;i<numbers.Length-1;i++)
            {
                if(numbers[i]%2==0)
                {
                    sum += numbers[i+1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length==0)
            {
                return "";
            }
            if (words[0] == " ")
            {
                return "";
            }
            var str = new List<string>();
            for(int i=0;i<words.Length;i++)
            {
                if(words[i] == "" || words[i] == " " || words[i]=="  ")
                {
                    i++;
                }
                str.Add(words[i].Trim());
              
                    
                
               
            }
            
            return String.Join(" ", str.ToArray()) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            var res = new List<double>();  
            for(int i=3;i<elements.Count;i+=4)
            {
                res.Add(elements[i]);
            }
            return res.ToArray();   
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int counter = 0;    
            if(nums == null || nums.Length==0)
            {
                return false;
            }
            for(int i = 0;i<nums.Length;i++)
            {
                for(int j = nums.Length-1;j>=0;j--)
                {
                    if(nums[j]+nums[i]==targetNumber)
                    {
                        counter++;
                    }
                }
            }
            if(counter>=2)
            {
                return true;
            }
            return false;
        }
    }
}
