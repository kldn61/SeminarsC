// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] GetRandomMatrix(int row, int column, int leftSide, int rigthSide)
{
    int[,] matrix = new int[row, column];
    for(int i = 0; i < matrix.GetLength(0); i++)  // matrix.GetLength(0) - (0) указывает длину строки
    {
        for(int j = 0; j < matrix.GetLength(1); j++)  // matrix.GetLength(1) - (1) указывает высоту колонки
        {
            matrix[i, j] = Random.Shared.Next(leftSide, rigthSide+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

const int Row = 3;
const int Column = 4;
const int LeftSide = -10;
const int RigthSide = 100;

int[,] myMatrix = GetRandomMatrix(Row, Column, LeftSide, RigthSide);
PrintMatrix(myMatrix);

