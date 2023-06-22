// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] CreateArray(int m, int n, double minValue, double maxValue)
{
    double[,] ar1 = new double[m ,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            ar1[i,j] = new Random().NextDouble();
        }
    }
    return ar1;
}

void PrintArray(double[,] ar2)
{
    for(int k = 0; k < ar2.GetLength(0); k++)
    {
        for(int l = 0; l < ar2.GetLength(1); l++)
        {
            Console.Write($"{ar2[k,l]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");
double[,] array = CreateArray(str, col, -2.25 , 6.75);
PrintArray(array);