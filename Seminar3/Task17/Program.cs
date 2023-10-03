// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату Х = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y = ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Номер четверти плоскости равно 1");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("Номер четверти плоскости равно 2");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("Номер четверти плоскости равно 3");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("Номер четверти плоскости равно 4");
}