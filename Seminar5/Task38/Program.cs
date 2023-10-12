// Задача 38. Задайте массив вещественных чисел Найдите разницу между
// максимальным и минимальным элементов массива

double FindMax(double[] array)
{
    double Max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > Max)
        Max = array[i];
    }
    return Max;
}

double FindMin(double[] array)
{
        double Min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < Min)
        Min = array[i];
    }
    return Min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double max = FindMax(array);
    double min = FindMin(array);
    double diffrent = max - min;
    return diffrent;
}

void PrintArray(double[] array)
{
    Console.WriteLine($"{string.Join("\t", array)}\t");
}

double[] array = new double[] { 3, 7.4, 22.3, 2, 78 };

Console.WriteLine("Массив: ");
PrintArray(array);
double diff = CalcDifferenceBetweenMaxMin(array);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");