using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public static class Recursion
    {
        public static int BinarySearch(int[] arr, int left, int right, int searchNumber)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == searchNumber) return mid;

                // If element is smaller than mid, then it can only be present in left subarray
                if (arr[mid] > searchNumber) return BinarySearch(arr, left, mid - 1, searchNumber);

                // Else the element can only be present in right subarray
                return BinarySearch(arr, mid + 1, right, searchNumber);
            }

            // We reach here when element is not present in array
            return -1;
        }

        public static int SimpleFibonacci(int number)
        {
            
            // Base case. Break recursion
            if (number <= 1) return number;
            // recursive calls
            return SimpleFibonacci(number - 1) + SimpleFibonacci(number - 2);
        }

        static List<int> FibonacciMemoizedList = new List<int>() { 0,1 } ;
        public static int FibonacciUsingMemoizedRecursion(int number)
        {
            Console.WriteLine(number);
            if (FibonacciMemoizedList.Contains(number))
                return number;

            var value = FibonacciUsingMemoizedRecursion(number - 1) + FibonacciUsingMemoizedRecursion(number - 2);

            FibonacciMemoizedList.Add(value);
            //Console.WriteLine(value);
            return value;
        }


    }
}
