using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {   
            if(words == null )
            { return false; }

            foreach (string str in words)
            {
               
                if(str == null)
                { return false; }
                if (ignoreCase == true)
                {
                    if (str.ToLower() == word.ToLower())
                    { return true; }
                }
                
            }
            if (ignoreCase == false)
            { return words.Contains(word); }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            int counter = 0;
            if(num <=1)
            { return false; }
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    counter++;  
                }
            }
            if(counter == 2)
            { return true; }
            return false; 
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if(str == null || str == "" )
            {
                return -1;
            }
            int count = -1;
            bool targInd;

            for (int i = 0; i < str.Length; i++)
            {
                targInd = true;        
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        targInd = false;
                    }
                }


                if (targInd==true)
                {
                    count = i;
                }

            }
            return count;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
           int count = 0;
           
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j] && i != j)
                    { break; }
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
            var nullcheck = new double[0];
            var nth = new List<double>();

            if (elements == null || elements.Count == 0)
            { return elements.ToArray(); }

            


            for(int i = 0; i < elements.Count; i++)
            {
                
                if (elements[i] % n == 0)
                { nth.Add(elements[i]); }

                if (n > elements.Count || n <= 0)
                {

                    return nullcheck;
                }
            }
            return nth.ToArray();   
        }
    }
}
