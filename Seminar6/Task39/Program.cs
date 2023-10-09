// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] --> [5 4 3 2 1]
// [6 7 3 6]   --> [6 3 7 ]

int[] GetRandomArray(int length, int leftSide, int rigthSide)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftSide, rigthSide + 1);
    }
    return array;
}

void ReverseArray(int[] sourceArray)
{
    for(int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length-i-1];
        sourceArray[sourceArray.Length-i-1] = temp;
    }
}

int length = 6;
int leftSide = -10;
int rigthSide =10;

int[] myArray = GetRandomArray(length, leftSide, rigthSide);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));
