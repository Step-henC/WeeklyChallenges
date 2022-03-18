using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            var switchedArray = ReverseFirstAndLast(new int[] { 1, 2, 3 });
        }

        static int[] ReverseFirstAndLast (int[] array)
        {
            var firstElement = array[0];
            var lastElement = array[^1];

            array[0] = lastElement;
            array[^1] = firstElement;

            return array;
        }
    }
}
