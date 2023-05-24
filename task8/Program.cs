Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;
Console.Write("Чётные числа в диапазоне: ");
while(i <= n)
{
        if(i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i = i + 1;
}
Console.ReadKey();