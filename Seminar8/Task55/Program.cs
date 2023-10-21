// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

int[,] GetRandomMatrix(int row, int column, int leftSide, int rigthSide)
{
    int[,] matrix = new int[row, column];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftSide, rigthSide+1);
        }
    }
    return matrix;
}

int[,] MatrixTransposition(int[,] matrix)
{
    int[,] tempMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = matrix[j,i];
        } 
    }
    return tempMatrix;
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
const int LeftSide = 0;
const int RigthSide = 10;

int[,] myMatrix = GetRandomMatrix(Row, Column, LeftSide, RigthSide);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] myMatrixChange = MatrixTransposition(myMatrix);
PrintMatrix(myMatrixChange);