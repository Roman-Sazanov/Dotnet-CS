// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int SumNaturalNumbers(int num1, int num2, int sum)
{
    if(num1 <= num2)
    {
        sum = sum + num1;
        return SumNaturalNumbers(num1 + 1, num2, sum);
    }
    else
    {
        return sum;
    }
}

Console.Clear();
int number1 = Prompt("Введите число M:");
int number2 = Prompt("Введите число N:");
int res = 0;
Console.WriteLine($"Сумма натуральных чисел от M до N равна {SumNaturalNumbers(number1, number2, res)}");
