// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray()
{
    int[,] ar1 = new int[3, 3];
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

int [,] MatrixDouble (int[,] ar3, int[,] ar4)
{
    int str = ar3.GetLength(0);
    int col = ar4.GetLength(1);
    int [,] res = new int[str, col];
    if(ar3.GetLength(1) == ar4.GetLength(0))
    {
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < ar3.GetLength(1); k++)
                {
                    res[i, j] += ar3[i, k] * ar4[k, j];
                }
            }
        }
   }
   return res;
}

Console.Clear();
int [,] array1 = CreateArray();
int [,] array2 = CreateArray();
Console.WriteLine("Первая матрица");
PrintArray(array1);
Console.WriteLine("Вторая матрица");
PrintArray(array2);
Console.WriteLine("Результат");
int [,] array3 = MatrixDouble (array1, array2);
PrintArray(array3);
