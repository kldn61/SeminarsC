// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
  
void PrintListAvr (double [] list)
    {
        Console.WriteLine("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
        {
            //Console.Write($"{list[i]:F2}\t");
            string result = string.Format("{0:f}", list[i]);
            Console.Write($"{result}\t");

        }
    }

double [] FindAverageInColumns (int [,] matrix)
    {
        double[] arr = new double[matrix.GetLength(1)];
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            double a = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                a = a + matrix[i,j];
            }
            a = a / matrix.GetLength(1);
        }
        return arr;
    }

int m = 3;
int n = 4;
int k = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));
