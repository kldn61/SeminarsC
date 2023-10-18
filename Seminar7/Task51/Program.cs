// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

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

void NewMatrix(int[,] matrix)
{
	int sum = 0;
	for(int i = 0; i < matrix.GetLength(0); i++)
	{
		for(int j = 0; j < matrix.GetLength(1); j++)
		{
			if(i == j)
			{
				sum = sum + matrix[i,j];
			}	
		}
	}
	Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
}

const int Row = 3;
const int Column = 3;
const int LeftSide = 0;
const int RigthSide = 10;

int[,] myMatrix = GetRandomMatrix(Row, Column, LeftSide, RigthSide);
PrintMatrix(myMatrix);
Console.WriteLine();
NewMatrix(myMatrix);








// int[,] GetMatrix(int rows, int columns)
// {
// 	int[,] arr = new int[rows, columns];
// 	for(int i = 0; i < arr.GetLength(0); i++)
// 	{
// 		for(int j = 0; j < arr.GetLength(1); j++)
// 		{
// 			arr[i,j] = Random.Shared.Next(0, 10);
// 		}
// 	}
// 	return arr;
// }

// void PrintMatrix(int[,] arr)
// {
// 	for(int i = 0; i < arr.GetLength(0); i++)
// 	{
// 		for(int j = 0; j < arr.GetLength(1); j++)
// 		{
// 			Console.Write(arr[i,j] + " ");
// 		}
// 		Console.WriteLine();
// 	}
// }

// void NewMatrix(int[,] arr)
// {
// 	int sum = 0;
// 	for(int i = 0; i < arr.GetLength(0); i++)
// 	{
// 		for(int j = 0; j < arr.GetLength(1); j++)
// 		{
			
// 			if(i == j)
// 			{
// 				sum = sum + arr[i,j];
// 			}	
// 		}
// 	}
// 	Console.WriteLine($"Сумма элементов главной диагонали: {sum}");	
// }

// const int Rows = 3;
// const int Columns = 4;
// int[,] arr = GetMatrix(Rows, Columns);
// PrintMatrix(arr);
// Console.WriteLine();
// NewMatrix(arr);
