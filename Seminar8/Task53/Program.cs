// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} \t");
        }
    Console.WriteLine();
    }
}

int[,] FillArr(int n, int m)
{
    Random random = new Random();
    int[,] arr = new int[n,m];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(0, 20);
        }
    }
    return arr;
}

void Swap(int[,] arr)            // Метод перестановки строк (1-ю с последней)
{
    int temp = 0;
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[0,i];
        arr[0,i] = arr[arr.GetLength(0)-1, i]; // i=0,1,...,n; arr[]=1,2,...,n-1
        arr[arr.GetLength(0)-1, i] = temp;
    }   
}

int n = 3;
int m = 4;
int[,] arr = FillArr(n,m);
PrintArray(arr);
Console.WriteLine();
Swap(arr);
PrintArray(arr);