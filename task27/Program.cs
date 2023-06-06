// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int num)
{
    int result = 0;
    while(num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Сумма всех цифр в числе: {result}");
    return result;
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
DigitSum(number);