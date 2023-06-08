// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int size)
{
    double[] ar = new double[size];
    for(int i = 0; i < size; i++)
    {
        ar[i] = new Random().NextDouble();
    }    
    return ar;
}

void PrintArray(double[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }    
}

double MaxMinDiff(double[] ar1)
{
    double diff = 0;
    double max = ar1[1];
    double min = ar1[1];
    for(int j = 0; j < ar1.Length; j++)
    {
        if(ar1[j] > max)
        {
            max = ar1[j];
        }
        else if(ar1[j] < min)
        {
            min = ar1[j];
        }
    }
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");
    return diff;
}

Console.Clear();
double[] array = CreateArray(8);
PrintArray(array);
Console.WriteLine();
MaxMinDiff(array);