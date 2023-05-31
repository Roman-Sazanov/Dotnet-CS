// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Second(int num2)
{
    if(num2 < 100 || num2 >= 1000)
    {
        Console.WriteLine("Введённое число не является трёхзначным");
    }
    else
    {
        int result = num2 / 10 % 10;
        Console.WriteLine("Результат: " + result);
    }
    return num2;
}

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
Second(num);
