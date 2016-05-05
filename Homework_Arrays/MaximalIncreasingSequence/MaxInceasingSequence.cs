//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;

class MaxInceasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        List<int> maxSeq = new List<int> { arr[0]};
        List<int> currentSeq = new List<int> { arr[0] };
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currentSeq.Add(arr[i + 1]);
            }
            else
            {
                currentSeq = new List<int> { arr[i + 1] };

            }
            if (currentSeq.Count > maxSeq.Count)
            {
                maxSeq = new List<int>(currentSeq);
            }
        }
        Print(maxSeq);
    }

    static void Print(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            Console.Write(list[i] + ", ");
        }
        Console.WriteLine(list[list.Count - 1]);
    }
}
