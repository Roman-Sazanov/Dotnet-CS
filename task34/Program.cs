// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] ar = new int[size];
    for(int i = 0; i < size; i++)
    {
        ar[i] = new Random().Next(100, 1000);
    }    
    return ar;
}

void PrintArray(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }    
}

int NumberDigits(int[] ar1)
{
    int count = 0;
    for(int j = 0; j < ar1.Length; j++)
    {
        if(ar1[j] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
    return count;
}

Console.Clear();
int[] array = CreateArray(8);
PrintArray(array);
Console.WriteLine();
NumberDigits(array);