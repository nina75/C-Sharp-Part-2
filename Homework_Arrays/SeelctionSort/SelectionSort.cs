/* Sorting an array means to arrange its elements in increasing order. 
   Write a program to sort an array. Use the Selection sort algorithm: 
   Find the smallest element, move it at the first position, 
   find the smallest from the rest, move it at the second position, etc. */

using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var arr = new int[n];
        var sortedArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            int min = arr[i];
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < min)
                {
                    int temp = arr[j];
                    arr[j] = min;
                    min = temp;
                }
            }
            //Console.WriteLine("min=" +min);
            sortedArr[i] = min;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(sortedArr[i]);
        }
    }
}
