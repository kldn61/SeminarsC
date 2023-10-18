// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[, ] matrix = new double[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble()*((maxLimitRandom-minLimitRandom)+minLimitRandom);
        }
    }
    return matrix;
}

void PrintArray(double[, ] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]:f2} \t");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;
int minLimitRandom = -10;
int maxLimitRandom = 10;
      
double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
PrintArray(result);
