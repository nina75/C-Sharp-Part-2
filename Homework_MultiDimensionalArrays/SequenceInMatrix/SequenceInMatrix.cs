//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of
//several neighbour elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

using System;
class SequenceInMatrix
{
    static void Main()
    {
        //Read the matrix
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int n = int.Parse(tokens[0]);
        int m = int.Parse(tokens[1]);
        var matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] strings = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = strings[j];
            }
        }

        //Solution
        string mostFrequent = matrix[0, 0];
        int bestCount = 1;
        int count = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                count = 1;

                //scan lines
                for (int i = col; i < matrix.GetLength(1) - 1; i++)
                {
                    if (matrix[row, i] == matrix[row, i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    mostFrequent = matrix[row, col];
                }
                count = 1;

                //scan columns
                for (int i = row; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i, col] == matrix[i + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    mostFrequent = matrix[row, col];
                }
                count = 1;

                //scan right diagonals
                for (int i = row, j = col; i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1; i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        mostFrequent = matrix[row, col];
                    }
                }

                //scan left diagonals
                for (int i = row, j = col; i < matrix.GetLength(0) - 1 && j > 0; i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        mostFrequent = matrix[row, col];
                    }
                }

            }
        }
        //Print the result
        //for (int i = 0; i < bestCount - 1; i++)
        //{
        //    Console.Write(mostFrequent + ", ");
        //}
        //Console.WriteLine(mostFrequent + " --> " + bestCount + " times");
        Console.WriteLine(bestCount);
    }
}
