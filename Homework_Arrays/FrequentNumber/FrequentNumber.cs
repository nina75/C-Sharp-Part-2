//Write a program that finds the most frequent number in an array of N elements.

using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (dict.ContainsKey(arr[i]))
            {
                dict[arr[i]]++;
            }
            else
            {
                dict.Add(arr[i], 1);
            }
        }

        int maxCount = 1;
        int mostFrequent = dict.Keys.First();

        foreach (var item in dict)
        {
            if (item.Value > maxCount)
            {
                maxCount = item.Value;
                mostFrequent = item.Key;
            }
            //Console.WriteLine(item.Key + "=" + item.Value);
        }

        Console.WriteLine("{0} ({1} times)", mostFrequent, maxCount);
        
        
    }
}
