// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int NaturalNumbers(int num)
{
    if(num > 0)
    {
        Console.Write($"{num} ");
        NaturalNumbers(num - 1);
    }
    return num;
}

Console.Clear();
int number = Prompt("Введите число N");
NaturalNumbers(number);