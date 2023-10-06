// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, 
// сумма отрицательных равна 20.

int[] GetRandomArray(int length, int leftSide, int rigthSide)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftSide, rigthSide + 1);
    }
    return array;
}

int SumPositiveNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int SumNegativeNumbers(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

const int Length = 12;
const int LeftSide = -9;
const int RigthSide = 9;

int[] myArray = GetRandomArray(Length, LeftSide, RigthSide);
string myArrayString = string.Join(", ", myArray);  // int[]  ->  string (массив выводит в строку)
Console.WriteLine(myArrayString);
int sumPositive = SumPositiveNumbers(myArray);
int sumNegative = SumNegativeNumbers(myArray);

Console.WriteLine($"Сумма положительных элементов массива равна {sumPositive} и отрицательных равна {sumNegative}");
