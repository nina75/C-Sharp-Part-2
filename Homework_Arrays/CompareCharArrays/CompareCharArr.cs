//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
class CompareCharArr
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
       // char result = '<';
        if (first == second)
        {
            Console.WriteLine("=");
            return;
        }

        int minLen = Math.Min(first.Length, second.Length);
        for (int i = 0; i < minLen; i++)
        {
            if (first[i] < second[i])
            {
                Console.WriteLine('<');
                return;
            }
            else if (first[i] > second[i])
            {
                Console.WriteLine('>');
                return;
            }
        }

        if (first.Length < second.Length)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine(">");
        }
    }
}
