//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArr
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i * 5;
        }
        Console.WriteLine(string.Join("\n", arr));
    }
}
