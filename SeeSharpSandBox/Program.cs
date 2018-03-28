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
            int[] array = {5, 4, 3, 2, 1};
            SortingAlgorithms.DisplaySequence(array);
            SortingAlgorithms.QuickSort(array, 0, array.Length-1);
            SortingAlgorithms.DisplaySequence(array);
            Console.ReadKey();



        }

        

    }
}
