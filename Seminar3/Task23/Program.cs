// Задача 23: 
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

void ShowCube(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i * i * i}");
    } 
}

int N = 3;
ShowCube(N);