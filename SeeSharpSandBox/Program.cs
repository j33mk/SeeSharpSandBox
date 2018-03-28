using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpSandBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Bubble sort algorithm
            char[] chars = "a quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = new[]{1,2,3,4,5,6,8};
            SortingAlgorithms.DisplaySequence(chars);
            SortingAlgorithms.BubbleSortDescendingCharacters(chars);
            SortingAlgorithms.DisplaySequence(chars);
            SortingAlgorithms.DisplaySequence(numbers);
            SortingAlgorithms.BubbleSortDescendingIntegers(numbers);
            SortingAlgorithms.DisplaySequence(numbers);
            Console.ReadKey();



        }

        

    }
}
