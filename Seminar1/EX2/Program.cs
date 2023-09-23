// Есть два числа, выяснить является одно число квадратом другого

Console.Write("Enter a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter b = ");
int b = int.Parse(Console.ReadLine());

if(a == b * b || b == a * a)
{
    Console.WriteLine("true");
}
else
{
   Console.WriteLine("false"); 
}
