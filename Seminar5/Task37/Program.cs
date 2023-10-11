// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5]  --> 5 8 3
// [6 7 3 6]    --> 12 10

static int[] Arr(int size)
{
    Random random = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 10);
    }
    return arr;
}
static int[] NewArr(int[] arr)
{
    int[] newArr = new int[arr.Length / 2 + arr.Length % 2];
    for(int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        if(arr[i] == arr[arr.Length - 1 - i])
        {
            newArr[i] = arr[i];
        }
    }
    return newArr;
}

int size = 10;
int[] arr = Arr(size);
Console.Write(String.Join(" ,", NewArr(arr)));