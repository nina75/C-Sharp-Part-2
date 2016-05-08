//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// a) 1	 5	 9	13      b) 1  8   9  16   c) 7  11  14  16    d)* 1  12  11  10
//    2	 6	10	14         2  7	 10	 15      4   8  12  15        2  13  16   9
//    3	 7	11	15         3  6	 11	 14      2   5   9  13        3  14  15   8
//    4	 8	12	16         4  5	 12	 13      1   3   6  10        4   5   6   7

using System;
class FillTheMatrix
{
    static int n;
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        string choice = Console.ReadLine();
        int[,] testMatrix = new int[n, n];
        int[,] testMatrixD = new int[n, n];
        switch (choice)
        {
            case "a":
                FillMatrixA(testMatrix);
                PrintMatrix(testMatrix);
                break;
            case "b":
                FillMatrixB(testMatrix);
                PrintMatrix(testMatrix);
                break;
            case "c":
                FillMatrixC(testMatrix);
                PrintMatrix(testMatrix);
                break;
            case "d":
                FillMatrixD(testMatrixD);
                PrintMatrix(testMatrixD);
                break;
        }
    }

    static void FillMatrixA(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + 1 + n * col;
            }
        }
    }
    static void FillMatrixB(int[,] matrix)
    {
        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;
        for (int i = 0; i < n * n; i++)
        {
            if (direction == "down" && currentRow == n)
            {
                currentCol++;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && currentRow < 0)
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }

            matrix[currentRow, currentCol] = i + 1;

            if (direction == "down")
            {
                currentRow++;
            }

            else if (direction == "up")
            {
                currentRow--;
            }
        }
    }

    static void FillMatrixC(int[,] matrix)
    {
        int currentRow = n - 1;
        int currentCol = 0;
        int counter = 0;
        while (currentCol < n)
        {
            if (currentRow == n)
            {
                currentRow = currentRow - currentCol - 1;
                currentCol = 0;
            }
            matrix[currentRow, currentCol] = counter + 1;
            currentRow++;
            currentCol++;
            counter++;
        }
        currentRow = 0;
        currentCol = 1;
        while (counter < n * n)
        {
            if (currentCol == n)
            {
                currentCol = currentCol - currentRow + 1;
                currentRow = 0;
            }
            matrix[currentRow, currentCol] = counter + 1;
            currentRow++;
            currentCol++;
            counter++;
        }
    }

    static void FillMatrixD(int[,] matrix)
    {
        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;
        for (int i = 0; i < n * n; i++)
        {
            if (direction == "down" && (currentRow == n || matrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                direction = "right";
            }
            if (direction == "right" && (currentCol == n || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }
            if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                direction = "left";
            }
            if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }

            matrix[currentRow, currentCol] = i + 1;

            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }

            else if (direction == "left")
            {
                currentCol--;
            }

        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {

            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.Write(matrix[row, matrix.GetLength(1) - 1]);
            Console.WriteLine();
        }

    }
}
