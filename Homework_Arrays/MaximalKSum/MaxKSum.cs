//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxKSum
{
    static void Main()
    {
        int[] arr = { 1, 5, 2, 7, 8, 9, 4, 6 };
        //int n = int.Parse(Console.ReadLine());
        //var arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        int k = int.Parse(Console.ReadLine());
        int maxSum = int.MinValue;
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                for (int l = j + 1; l < arr.Length; l++)
                {
                    Console.WriteLine(arr[i] + " " + arr[j] + " " + arr[l]);
                }
            }
            //break;
        }

    }
}
