// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int SumOddElements(int[] array)
    {
    int sum = 0;
    for(int i = 1; i < array.Length; i = i +2)
    {       
        sum = sum + array[i];
    }
    return sum;
    }

void PrintArray(int[] array)
    {
        Console.WriteLine($"{string.Join("\t", array)}\t");
    }

int[] array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
PrintArray(array);
int sumOdd = SumOddElements(array);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");