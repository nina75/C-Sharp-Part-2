//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix 
//and prints its size.

using System;
class LargestArea
{
    static bool[,] isVisited;
    static int count;
    static void Main()
    {
        //Read the matrix
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int n = int.Parse(tokens[0]);
        int m = int.Parse(tokens[1]);
        var matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] nums = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(nums[j]);
            }
        }

        //Declare a bool matrix, where if the position is checked the cell becomes true
        isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        for (int row = 0; row < isVisited.GetLength(0); row++)
        {
            for (int col = 0; col < isVisited.GetLength(1); col++)
            {
                isVisited[row, col] = false;
            }
        }

        //Call SearchEquals method for each element of the matrix
        int bestCount = 1;
        int mostFrequent = matrix[0, 0];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                count = 0;
                SearchEquals(matrix, row, col);
                if (count > bestCount)
                {
                    bestCount = count;
                    mostFrequent = matrix[row, col];
                }
            }
        }

        //Print the result
        //Console.WriteLine("{0} --> {1} times ", mostFrequent, bestCount);
        Console.WriteLine(bestCount);

    }
    //Check is cell in the array
    static bool IsCellInMatrix(int[,] matrix, int i, int j)
    {
        return i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1);
    }

    //Searching equals elements in position(row, col) 
    static void SearchEquals(int[,] matrix, int row, int col)
    {
        int value = matrix[row, col];
        isVisited[row, col] = true;
        count++;

        if (IsCellInMatrix(matrix, row, col + 1) && matrix[row, col + 1] == value && isVisited[row, col + 1] == false)
        {
            SearchEquals(matrix, row, col + 1);
        }

        if (IsCellInMatrix(matrix, row, col - 1) && matrix[row, col - 1] == value && isVisited[row, col - 1] == false)
        {
            SearchEquals(matrix, row, col - 1);
        }

        if (IsCellInMatrix(matrix, row - 1, col) && matrix[row - 1, col] == value && isVisited[row - 1, col] == false)
        {
            SearchEquals(matrix, row - 1, col);
        }

        if (IsCellInMatrix(matrix, row + 1, col) && matrix[row + 1, col] == value && isVisited[row + 1, col] == false)
        {
            SearchEquals(matrix, row + 1, col);
        }
    }
}
