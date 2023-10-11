// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2       --> 2
// -1, -7, 567, 89, 223  --> 3

int[] GetRandomArray(int length, int leftSide, int rigthSide)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftSide, rigthSide + 1);
    }
    return array;
}

int QuantityPositiveNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += 1;
        }
    }
    return sum;
}

const int Length = 10;
const int LeftSide = -9;
const int RigthSide = 9;

int[] myArray = GetRandomArray(Length, LeftSide, RigthSide);
string myArrayString = string.Join(", ", myArray);
Console.WriteLine(myArrayString);
int sumPositive = QuantityPositiveNumbers(myArray);
Console.WriteLine($"Количество положительных чисел = {sumPositive}");
