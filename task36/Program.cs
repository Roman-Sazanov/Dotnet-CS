// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] ar = new int[size];
    for(int i = 0; i < size; i++)
    {
        ar[i] = new Random().Next();
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

int SumElements(int[] ar1)
{
    int sum = 0;
    for(int j = 0; j < ar1.Length; j++)
    {
        if(j % 2 == 0)
        {
            sum = sum + ar1[j];
        }
    }
    Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: {sum}");
    return sum;
}

Console.Clear();
int[] array = CreateArray(8);
PrintArray(array);
Console.WriteLine();
SumElements(array);