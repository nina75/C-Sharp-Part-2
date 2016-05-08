//Write a program that reads a rectangular matrix of size N x M and finds in it 
//the square 3 x 3 that has maximal sum of its elements. Print that sum.

using System;
class MaxSum
{
    static void Main()
    {
        //int[,] matrix = {
        //                      {2, 3, 6, 8, 1, 7},
        //                      {8, 5, 9, 9, 9, 1},
        //                      {4, 3, 9, 9, 9, 0},
        //                      {2, 0, 9, 9, 9, 4},
        //                   };

        //Read the matrix
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int n = int.Parse(tokens[0]);
        int m = int.Parse(tokens[1]);
        var matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(numbers[j]);
            }
        }

        //Find the max sum
        int bestSum = int.MinValue;
        int squareSide = 3;
        int currentSum, startRow = 0, startCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - squareSide + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - squareSide + 1; col++)
            {
                currentSum = 0;
                for (int i = row; i < row + squareSide; i++)
                {
                    for (int j = col; j < col + squareSide; j++)
                    {
                        currentSum += matrix[i, j];
                    }
                }
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    startRow = row;
                    startCol = col;
                }
            }
        }
        //Print the result
        //for (int row = startRow; row < startRow + squareSide; row++)
        //{
        //    for (int col = startCol; col < startCol + squareSide; col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}
        Console.WriteLine(bestSum);
    }
}
