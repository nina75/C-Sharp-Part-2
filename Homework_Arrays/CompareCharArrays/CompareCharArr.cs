//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArr
{
    static void Main()
    {
        var arr1 = new char[] { 'a', 'b', 'c' };
        var arr2 = new char[] { 'a', 'b', 'c', 'd' };
        var arr3 = new char[] { 'a', 'b', 'c', 'd' };
        Console.WriteLine(CompareCharArrays(arr1, arr2));
        Console.WriteLine(CompareCharArrays(arr2, arr3));
    }

    static bool CompareCharArrays(char[] arr1, char[] arr2)
    {
        bool isEquals = true;
        if (arr1.Length != arr2.Length)
        {
            isEquals = false;
        } 
        else
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isEquals = false;
                }
            }
        }

        return isEquals;
    }
}
