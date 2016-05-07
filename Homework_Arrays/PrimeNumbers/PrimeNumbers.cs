//Write a program that finds all prime numbers in the range [1 ... N]. 
//Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

using System;
class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int theBiggestNum = 0;

        //At the begining set all numbers to prime
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        //Use the sieve of Eratosthenes algorithm to strike() not prime numbers
        int len = (int)Math.Sqrt(isPrime.Length);
        int temp = 0;
        for (int i = 2; i <= len; i++)
        {
            if (isPrime[i] == true)
            {
                temp = i * i;
                while (temp <= n)
                {
                    isPrime[temp] = false;
                    temp += i;
                }
            }
        }

        //Print the result
        for (int i = 2; i < isPrime.Length; i++)
        {
            if (isPrime[i] == true)
            {
                theBiggestNum = i;
            }
        }
        Console.WriteLine(theBiggestNum);
    }
}
