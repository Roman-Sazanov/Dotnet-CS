// Задача 62 *** Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralArray(int[,] ar1, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        ar1[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)
        {
            j++;
        }
        else if (i < j && i + j >= size - 1)
        {
            i++;
        }
        else if (i >= j && i + j > size - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
        value++;
    }
}

void PrintArray(int[,] ar2, int size)
{
    Console.WriteLine($"Массив размером {size} x {size}, заполнен по спирали");
    Console.WriteLine();
    for(int i = 0; i < ar2.GetLength(0); i++)
    {
        for(int j = 0; j < ar2.GetLength(1); j++)
        {
            if (ar2[i, j] < 10)
            {
                Console.Write("0" + ar2[i, j]);
                Console.Write(" ");
            }
            else
            {
                Console.Write(ar2[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
int size = 4;
int [,] array = new int[size, size];
SpiralArray(array, size);
PrintArray(array, size);