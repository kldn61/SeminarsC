// Есть два числа, выяснить является одно число квадратом другого

Console.Write("Enter 1st numb1 = ");
int numb1 = int.Parse(Console.ReadLine());
Console.Write("Enter 2nd numb2 = ");
int numb2 = int.Parse(Console.ReadLine());

if(numb1 == numb2 * numb2 || numb2 == numb1 * numb1)
{
    Console.WriteLine("true");
}
else
{
   Console.WriteLine("false"); 
}
