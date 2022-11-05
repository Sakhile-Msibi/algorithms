using System;

namespace BinarySearchExample
{
    class Program
    {
        static void display(int[] arr1)
        {
            foreach (int i in arr1)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        //Iterative implementation of binary search
        static int binarySearch(int[] arr, int k)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (end > start)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == k)
                    return mid;

                if (arr[mid] > k)
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return -1;
        }

        static void result(int[] arr2, object k)
        {
            // Searches a value k in an array using binary search array method,
            int res = Array.BinarySearch(arr2, k);

            if (res < 0)
            {
                Console.WriteLine("The element to search for ({0}) is not found.", k);
            }
            else
            {
                Console.WriteLine("The element to search for ({0}) is at index {1}.", k, res);
            }
        }

        static void result(int[] arr2, int k)
        {
            // Searches a value k in an array using binary search array method,
            int res = binarySearch(arr2, k);

            if (res < 0)
            {
                Console.WriteLine("The element to search for ({0}) is not found.", k);
            }
            else
            {
                Console.WriteLine("The element to search for ({0}) is at index {1}.", k, res);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 7, 6, 2, 3, 4 };

            Array.Sort(arr);

            Console.WriteLine("The elements of Sorted Array: ");

            display(arr);

            object s = 8;
            int k = 8;

            result(arr, s);
            result(arr, k);

            object s1 = 4;
            k = 4;

            result(arr, s1);
            result(arr, k);
        }
    }
}
