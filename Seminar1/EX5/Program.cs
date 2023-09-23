// Написать программу которая принимает трёхзначное число и выдаёт последнюю цифру этого числа
// 345 -> 5

Console.Write("Введите число N = ");
int number = int.Parse(Console.ReadLine()!);
if(number >= 100 && number < 1000)
{
    Console.WriteLine($"Последняя цифра = {number % 10}");
}
else
{
    Console.WriteLine("Неверно введено число");
}