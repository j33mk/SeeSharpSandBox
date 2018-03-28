using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpSandBox
{
    public class SortingAlgorithms
    {
        private SortingAlgorithms()
        {
            
        }
        //This will sort the numbers in ascending order
        public static void BubbleSortAscendingIntegers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] >= array[j])
                    {
                        Swap(i, j, array);
                    }
                }
            }
        }
        //This will sort the numbers in descending order
        public static void BubbleSortDescendingIntegers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        Swap(i, j, array);
                    }
                }
            }
        }
        //This will sort the characters in ascending order
        public static void BubbleSortAscendingCharacters(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] >= array[j])
                    {
                        Swap(i, j, array);
                    }
                }
            }
        }
        //This will sort the characters in descending order
        public static void BubbleSortDescendingCharacters(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        Swap(i,j,array);
                    }
                }
            }
        }
        public static void DisplaySequence(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write(a);
            }
            Console.WriteLine();

        }
        public static void DisplaySequence(char[] array)
        {
            foreach (char a in array)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }

        private static void Swap(int i, int j, int[] array)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void Swap(int i, int j, char[] array)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
