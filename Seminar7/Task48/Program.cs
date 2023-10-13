// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ= m+n. Выведите полученный массив на экран. m = 3, n = 4.

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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

const int m = 3;
const int n = 4;

int[,] myMatrix = GetMatrix(m, n);
PrintMatrix(myMatrix);
