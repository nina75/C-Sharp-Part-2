//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

using System;
class BinarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());

        int left = 0, right = n - 1, middle;
        int index = 0;
        bool isWantedInArray = false;

        if (x == array[left])
        {
            index = left;
            isWantedInArray = true;
        }
        if (x == array[right])
        {
            index = right;
            isWantedInArray = true;
        }

        while (right - left > 1)
        {
            middle = (left + right) / 2;
            if (x == array[middle])
            {
                index = middle;
                isWantedInArray = true;
                break;
            }
            else if (x < array[middle])
            {
                right = middle;
            }
            else
            {
                left = middle;
            }
        }
            Console.WriteLine(isWantedInArray ? index : -1);
    }
}
