//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaxSequence
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int maxCount = 1, currentCount = 1, element = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                element = arr[i];
            }
        }
        for (int i = 0; i < maxCount - 1; i++)
        {
            Console.Write(element + ", ");
        }
        Console.WriteLine(element);
    }

}
