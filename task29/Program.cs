// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int [] CreateArray(int length)
{
    int [] array = new int[length];
    Random digit = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = digit.Next(0, 1048576);
    }
    return array;
}

int wide = Prompt("Длина массива: ");
int[] array1 = CreateArray(wide);
for(int j = 0; j < wide; j++)
    Console.Write("[" + array1[j] + "]");
