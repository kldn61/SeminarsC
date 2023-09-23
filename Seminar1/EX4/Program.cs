// Написать программу которая принимает число N и выводет все целые числа ]-N; N[
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Enter a number N = ");
int number = int.Parse(Console.ReadLine()!);
int negative = -number;

while(negative <= number)
{
    Console.WriteLine($"number = {negative}");
    negative ++;
}
