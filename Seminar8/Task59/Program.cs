// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

void PrintArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
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

int[] FindMin(int[,] arr)
{
    int min = arr[0,0];
    int[] minCell = new int[2];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] < min)
            {
                min = arr[i,j];
                minCell[0] = i;
                minCell[1] = j;
            }
        }
    }
    Console.WriteLine($"{minCell[0]} {minCell[1]}");
    return minCell;
}

int[,] NewArr(int[,] arr)
{
    int rowOff = 0;
    int columnOff = 0;
    int[] minCell = FindMin(arr);
    int[,] newArr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    for(int i = 0; i < newArr.GetLength(0); i++)
    {
        if(i == minCell[0]) rowOff++;
        
            for(int j = 0; j < newArr.GetLength(1); j++)
            {
                if(j == minCell[1]) columnOff++;
                
                newArr[i,j] = arr[i+rowOff, j+columnOff];
            }
        columnOff = 0;
    }
    return newArr;
}

int n = 5;
int m = 5;
int[,] arr = FillArr(n,m);
PrintArr(arr);
Console.WriteLine();
int[,] newArr = NewArr(arr);
PrintArr(newArr);

