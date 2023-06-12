// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int[] CreateArray(int size)
{
    int[] ar1 = new int[size];
    for(int i = 0; i < ar1.Length; i++)
    {
        ar1[i] = Prompt($"Введите {i + 1}-е число:");
    }
    return ar1; 
}

void PrintArray(int[] ar2)
{
    for(int i = 0; i < ar2.Length; i++)
    {
        Console.Write($"{ar2[i]} ");
    }
}

int CountNumbers (int[] ar3)
{
    int sum = 0;
    for(int i = 0; i < ar3.Length; i++)
    {
        if(ar3[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}

int number = Prompt("Введите количество чисел:");
int [] array = CreateArray(number);
PrintArray(array);
int number1 = CountNumbers(array);
Console.WriteLine($"Количество положительных чисел: {number1}.");