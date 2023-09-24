// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int n = Random.Shared.Next(100, 1000);
Console.WriteLine(n);
int lastDigit = n % 10;
int firstDigit = n / 100;
int result = firstDigit * 10 + lastDigit;
Console.WriteLine(firstDigit);
Console.WriteLine(lastDigit);
Console.WriteLine(result);
