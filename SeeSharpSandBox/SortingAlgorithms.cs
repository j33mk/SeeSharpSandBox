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
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is 
                now at right place */
                int pi = Partition(arr, low, high);

                // Recursively sort elements before
                // partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        public static int Partition(int[] arr, int low,int high)
        {
            int pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller 
                // than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
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
