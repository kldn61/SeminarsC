// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

// int[,] GetRandomMatrix(int row, int column, int leftSide, int rigthSide)
// {
//     int[,] matrix = new int[row, column];
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Random.Shared.Next(leftSide, rigthSide+1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// const int Row = 3;
// const int Column = 4;
// const int LeftSide = 0;
// const int RigthSide = 7;

// int[,] ectMatrix = GetRandomMatrix(Row, Column, LeftSide, RigthSide);
// PrintMatrix(ectMatrix);




// void Main(string[] args)
// {
// 	int n = Convert.ToInt32(Console.ReadLine());
// 	int m = Convert.ToInt32(Console.ReadLine());
// 	int[,] arr = GetMatrix(rows:n, columns:m);
// 	PrintMatrix(arr);
// 	Console.WriteLine();
// 	NewMatrix(arr);
// }

int[,] GetMatrix(int rows, int columns)
{
	int[,] arr = new int[rows, columns];
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i,j] = i + j;
		}
	}
	return arr;
}

void PrintMatrix(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i,j] + " ");
		}
		Console.WriteLine();
	}
}

void NewMatrix(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			if(i % 2 != 0 && j % 2 != 0)
			{
				arr[i, j] = arr[i, j] * arr[i, j];
			}	
		}
	}
	PrintMatrix(arr);	
}

const int Rows = 3;
const int Columns = 4;
int[,] arr = GetMatrix(Rows, Columns);
PrintMatrix(arr);
Console.WriteLine();
NewMatrix(arr);

