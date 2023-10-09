// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45  --> 101101

Console.Write("Enter a number = ");
int number = int.Parse(Console.ReadLine()!);

int Convert(int arg)
{
    int arraysize = 0;
    int number = arg;
    for (int index = 0; arg > 0; index++)
    {
        arg = arg / 2;
        arraysize++;
    }
    return arraysize;
}

int[] Fillarray(int size, int number)
{
    int[] array = new int[size];
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = number % 2;
        number = number / 2;
    }
    return array;
}

int[] Reversearray(int[] array)
{
    for (int index = 0; index < array.Length / 2; index++)
    {
        int temp = array[index];
        array[index] = array[array.Length - 1 - index];
        array[array.Length - 1 - index] = temp;
    }
    return array;
}

Convert(number);
int[] array = Fillarray(Convert(number), number);
Console.WriteLine(string.Join(", ", Reversearray(array)));