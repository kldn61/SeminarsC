// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве

int CountEvenElements(int[] array)
{
    
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"{string.Join("\t", array)}\t");
}


int[] array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
Console.WriteLine("Массив: ");
PrintArray(array);
int evenCount = CountEvenElements(array);
Console.WriteLine($"Количество четных элементов: {evenCount}");
