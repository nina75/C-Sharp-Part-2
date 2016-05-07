//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxKSum
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        var arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < k; i++)
        {
            maxSum += arr[i];
        }
        Console.WriteLine(maxSum);
        

    }
}
