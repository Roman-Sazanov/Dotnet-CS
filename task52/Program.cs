// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int n = int.Parse(Console.ReadLine());
//     return n;
// }

int[,] CreateArray()
{
    int[,] ar1 = new int[3, 4];
    for(int i = 0; i < ar1.GetLength(0); i++)
    {
        for(int j = 0; j < ar1.GetLength(1); j++)
        {
            ar1[i, j] = new Random().Next(1, 5);
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

void ArrayMiddleCol (int[,] ar3)
{
    for(int i = 0; i < ar3.GetLength(1); i++)
    {
        decimal mid = 0.00M;
        decimal sum = 0;
        for(int j = 0; j < ar3.GetLength(0); j++)
        {
            sum = sum + ar3[j, i];
            mid = sum / 3;
        }
        Console.WriteLine($"Сумма элементов {i + 1}-го столбца равна {sum}");
        Console.WriteLine($"Среднее арифметическое {i + 1}-го столбца равно {mid.ToString("F2")}");
    }
}

Console.Clear();
int [,] array = CreateArray();
PrintArray(array);
ArrayMiddleCol(array);