//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
class MergeSorting
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Sort(arr);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }


    }
    public static void Sort(int[] arr)
    {
        MergeSort(arr, 0, arr.Length);
    }

    public static void MergeSort(int[] arr, int low, int high)
    {
        int n = high - low;
        if (n <= 1)
            return;

        int mid = low + n / 2;

        MergeSort(arr, low, mid);
        MergeSort(arr, mid, high);

        var aux = new int[n];
        int i = low, j = mid;
        for (int k = 0; k < n; k++)
        {
            if (i == mid) aux[k] = arr[j++];
            else if (j == high) aux[k] = arr[i++];
            else if (arr[j].CompareTo(arr[i]) < 0) aux[k] = arr[j++];
            else aux[k] = arr[i++];
        }

        for (int k = 0; k < n; k++)
        {
            arr[low + k] = aux[k];
        }
    }
}
