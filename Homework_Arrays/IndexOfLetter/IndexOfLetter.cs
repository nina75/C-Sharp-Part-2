﻿//Write a program that creates an array containing all letters from the alphabet (a-z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetter
{
    static void Main()
    {
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(word[i] - 97);
        }
    }
}
