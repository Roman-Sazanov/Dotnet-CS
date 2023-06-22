// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int[,] CreateArray()
{
    int[,] ar1 = new int[4, 4];
    for(int i = 0; i < ar1.GetLength(0); i++)
    {
        for(int j = 0; j < ar1.GetLength(1); j++)
        {
            ar1[i, j] = new Random().Next(10, 50);
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

int ArrayPosition (int[,] ar3, int str, int col)
{
    if(str > ar3.GetLength(0))
    {
        Console.WriteLine("Вы ввели значение строки более 4. Такого элемента не существует в заданном массиве");
    }
    else if(col > ar3.GetLength(1))
    {
        Console.WriteLine("Вы ввели значение столбца более 4. Такого элемента не существует в заданном массиве");
    }
    int x = str - 1;
    int y = col - 1;
    int pos = ar3[x, y];
    if(x <= ar3.GetLength(0) || y <= ar3.GetLength(1))
    {
        Console.Write($"Элемент равен: {pos}");
    }
    return pos;
}

Console.Clear();
int [,] array = CreateArray();
PrintArray(array);
int number1 = Prompt("Введите номер строки от 1 до 4:");
int number2 = Prompt("Введите номер столбца от 1 до 4:");
ArrayPosition(array, number1, number2);