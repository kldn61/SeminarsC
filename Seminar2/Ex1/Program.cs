// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int n = Random.Shared.Next(10, 100); // (10, 100) -> [10, 99]
Console.WriteLine(n);
int lastDigit = n % 10;
int firstDigit = n / 10;

if(lastDigit > firstDigit)
{
    Console.WriteLine($"Последняя цифра наибольшая {lastDigit}");
}
else if(lastDigit < firstDigit)
{
    Console.WriteLine($"Первая цифра наибольшая {firstDigit}");
}
else
{
    Console.WriteLine("Цифры равны");
}
