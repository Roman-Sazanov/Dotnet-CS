// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int[,] CreateArray(int str, int col)
{
    int[,] ar1 = new int[str, col];
    for(int i = 0; i < ar1.GetLength(0); i++)
    {
        for(int j = 0; j < ar1.GetLength(1); j++)
        {
            ar1[i, j] = new Random().Next(1, 30);
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

int[,] OrderArray (int[,] ar3)
{
    for(int k = 0; k < ar3.GetLength(0); k++)
    {
        for(int l = 0; l < ar3.GetLength(1); l++)
        {
            for(int m = 0; m < ar3.GetLength(1)-1; m++)
            {
                if(ar3[k, m] < ar3[k, m + 1])
                {
                    int temp = ar3[k, m + 1];
                    ar3[k, m + 1] = ar3[k, m];
                    ar3[k, m] = temp;
                }
            }
        }
    }
    return ar3;
}

Console.Clear();
int number1 = Prompt("Введите количество строк:");
int number2 = Prompt("Введите количество столбцов:");
int [,] array = CreateArray(number1, number2);
PrintArray(array);
Console.WriteLine();
int [,] array1 = OrderArray(array);
PrintArray(array1);