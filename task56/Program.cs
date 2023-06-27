// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray()
{
    int[,] ar1 = new int[4, 4];
    for(int i = 0; i < ar1.GetLength(0); i++)
    {
        for(int j = 0; j < ar1.GetLength(1); j++)
        {
            ar1[i, j] = new Random().Next(1, 10);
        }
    }
    return ar1; 
}

void PrintArray(int[,] ar2)
{
    for(int i = 0; i < ar2.GetLength(0); i++)
    {
        for(int j = 0; j < ar2.GetLength(1); j++)
        {
            Console.Write($"{ar2[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinSum (int[,] ar3)
{
    int str = 0;
    int min = 0;
    for(int i = 0; i < ar3.GetLength(1); i++)
    {
        min = min + ar3[0, i];
    }
    str = 1;
    Console.WriteLine($"Сумма элементов 1-й строки равна {min}");
    for(int i = 1; i < ar3.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < ar3.GetLength(1); j++)
        {
            sum = sum + ar3[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1}-й строки равна {sum}");
        if(min > sum)
        {
            min = sum;
            str = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой: {str + 1}");
    return str + 1;
}

Console.Clear();
int [,] array = CreateArray();
PrintArray(array);
MinSum(array);