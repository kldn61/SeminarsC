// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//    4; массив [6, 7, 19, 345, 3]  --> нет
//    3; массив [6, 7, 19, 345, 3]  --> да

int[] Array(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 10);
    }
    return array;
}

bool Сomparison(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            return true;
        }
    }
    return false;
}

// Console.Write("Enter array size = ");
int[] NewArray = Array(10);
Console.WriteLine(string.Join(", ", NewArray));
bool result = Сomparison(NewArray, 3);
Console.WriteLine(result);

