Console.WriteLine("Введите число для проверки:");
double number = double.Parse(Console.ReadLine());
double n = number;
if(n % 2 == 0)
{
    Console.WriteLine("Чётное число");
}
else
{
    Console.WriteLine("Нечётное число");
}
Console.ReadKey();