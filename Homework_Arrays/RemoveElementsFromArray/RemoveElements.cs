//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way 
//that the remaining array is sorted in increasing order. Print the minimal number of elements that need 
//to be removed in order for the array to become sorted.

using System;
using System.Collections.Generic;

class RemoveElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }
        int[] size = new int[numbers.Count];

        for (int i = 0; i < numbers.Count; i++)
        {
            size[i] = 1;
        }

        int max = 1;
        for (int i = 1; i < numbers.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] >= numbers[j] && size[i] <= size[j] + 1)
                {
                    size[i] = size[j] + 1;
                    if (max < size[i])
                    {
                        max = size[i];
                    }
                }
            }
        }

        Console.WriteLine(n - max);
    }
}
