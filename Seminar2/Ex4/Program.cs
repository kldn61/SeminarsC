// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int a = 7;
int b = 23;

if(n % a == 0 && n % b == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("нет");
}
