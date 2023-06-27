// Задача 60. *** ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void CreateArray(int[,,] ar1)
{
    int[] temp = new int[ar1.Length];
    int num;
    for(int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for(int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(1, 10);
                    j = 0;
                    num = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < ar1.GetLength(0); x++)
    {
        for (int y = 0; y < ar1.GetLength(1); y++)
        {
            for (int z = 0; z < ar1.GetLength(2); z++)
            {
                ar1[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] ar2)
{
    for(int i = 0; i < ar2.GetLength(0); i++)
    {
        for(int j = 0; j < ar2.GetLength(1); j++)
        {
            for(int k = 0; k < ar2.GetLength(2); k++)
            {
                Console.Write($"{ar2[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
int [,,] array3D = new int [4, 3, 2];
CreateArray(array3D);
PrintArray(array3D);
