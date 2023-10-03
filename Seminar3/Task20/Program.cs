// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// A (3, 6); B (2, 1)  -> 5,09
// A (7, 5); B (1, 1)  -> 7,21


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите х для точки 1: ");
int y1 = ReadInt("Введите y для точки 1: ");
int x2 = ReadInt("Введите х для точки 2: ");
int y2 = ReadInt("Введите y для точки 2: ");

double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine($"Расстояние = {length}");
