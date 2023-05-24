Console.WriteLine("Введите число а ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
}
Console.WriteLine("Максимальное число = " + max);