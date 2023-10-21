// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

int[,] FillArr(int m, int n)
{
    int[,] arr = new int[m,n];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

int[,] PrintArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} \t");
        }
        Console.WriteLine();
    }
    return arr;
}

void CheckArr(int[,] arr)
{
    for(int k = 0; k <= 9; k++)
    {
        int count = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(arr[i,j] == k )
                {
                    count++;
                }
            }
        }
        if(count > 0)
        {
            Console.WriteLine($" {k} has {count} time");
        }
        
    }
}

Console.Clear();

Console.Write("Enter m = ");
int m =int.Parse(Console.ReadLine()!);

Console.Write("Enter n = ");
int n =int.Parse(Console.ReadLine()!);

Console.WriteLine();

int[,] arr = FillArr(m,n);
PrintArr(arr);

Console.WriteLine();

CheckArr(arr);