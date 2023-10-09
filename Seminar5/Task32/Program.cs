// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] --> [4, 8, -8, -2]

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 10);
        Console.Write(array[index]);
    }
    return array;
}

int[] PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = array[index] * -1;
        Console.Write(array[index]);
    }
    return array;
}

Console.Write("Enter array size = ");
int size = int.Parse(Console.ReadLine()!);

int[] array = FillArray(size);
Console.WriteLine("");
PrintArray(array);

