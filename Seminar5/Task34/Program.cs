// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами Напишите программу,
// которая покажет количество чётных чисел в массиве

int[] CountEvenElements(int size)
{
    int[] array = new int[size];
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("\t ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("\t ");
    Console.WriteLine();
}

PrintArray(array);