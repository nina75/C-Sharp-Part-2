//Write a program that finds the maximal sum of consecutive elements 
//in a given array of N numbers.

using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        long maxSum = long.MinValue;
        long currentSum = 0;
        for (int i = 0; i < n; i++)
        {
            currentSum += arr[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }
        Console.WriteLine(maxSum);

    }
}
