//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
class CompareArr
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var arr1 = new int[n];
        var arr2 = new int[n];
        bool isEquals = true;

        //Read the first array
        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        //Read the second array
        for (int i = 0; i < n; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        //Compare the arrays
        for (int i = 0; i < n; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isEquals = false;
                break;
            }
        }
        //Print the result
        Console.WriteLine(isEquals ? "Equals" : "Not equals");
    }
}
