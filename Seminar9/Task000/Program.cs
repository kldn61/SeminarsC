// Task000 Нахождение N! с помощью рекурсии

uint N = 10; // int -целое число; uint -целое положительное число.

uint Factorial(uint n)
{
    if(n == 0 || n == 1) return 1;
    return n * Factorial(n-1);
}
uint result = Factorial(N);
Console.WriteLine($"N! = {result}");