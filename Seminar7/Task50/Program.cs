// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray (int [,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]} \t");
            }
            Console.WriteLine();
        }
    }
  
int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            if(i == 0)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        matrix[i,j] = 1;
                    }
                    else
                    {
                        matrix[i,j] = matrix[i,j-1] + k;
                    }
                }
            }
            else
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        matrix[i,j] = matrix[i-1, matrix.GetLength(1)-1] + k;
                    }
                    else
                    {
                        matrix[i,j] = matrix[i,j-1] + k;
                    }
                }
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        matrix[i,j] = matrix[i-1, matrix.GetLength(1)-1] + k;
                    }
                    else
                    {
                        matrix[i,j] = matrix[i,j-1] + k;
                    }    
                }    
            }  
        }
        return matrix;
    }   
  
int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {
        int[] results = {0,1};
        if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
        {
            results[0] = 0;
        }
        else
        {
            results[1] = 1;
        }
        return results;
    }

void PrintCheckIfError (int[] results, int X, int Y)
    {
         if (results[0] == 0)
        {
            //Console.WriteLine($"The number in [{X}, {Y}] is {results[1]}");
            Console.WriteLine("There is no such index");
        }
        else
        {
            //Console.WriteLine("There is no such index");
            Console.WriteLine($"The number in [{X}, {Y}] is {results[1]}");
        }
    }

int m = 3;
int n = 4;
int k = 2;
int x = 3;
int y = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);