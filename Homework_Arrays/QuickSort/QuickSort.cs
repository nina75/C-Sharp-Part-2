//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;

class QuickSort
{
    static int n;
    static List<int> unsortedArray;
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        unsortedArray = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            unsortedArray.Add(number);
        }
        List<int> sortedArray = QuickSorting(unsortedArray);
        //Console.WriteLine();
        PrintArray(sortedArray);
    }

    static List<int> QuickSorting(List<int> arr)
    {
        if (arr.Count <= 1)
        {
            return arr;
        }
        int pivot = arr[arr.Count / 2];
        List<int> less = new List<int>();
        List<int> greater = new List<int>();

        for (int i = 0; i < arr.Count; i++)
        {
            if (i != arr.Count / 2)
            {
                if (arr[i] <= pivot)
                {
                    less.Add(arr[i]);
                }
                else
                {
                    greater.Add(arr[i]);
                }
            }
        }
        return ConcatenateList(QuickSorting(less), pivot, QuickSorting(greater));
    }
    static List<int> ConcatenateList(List<int> less, int pivot, List<int> greater)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < less.Count; i++)
        {
            result.Add(less[i]);
        }

        result.Add(pivot);

        for (int i = 0; i < greater.Count; i++)
        {
            result.Add(greater[i]);
        }

        return result;
    }
    static void PrintArray(List<int> arr)
    {
        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
