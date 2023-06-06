// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int num2 = int.Parse(Console.ReadLine());
double result = Math.Pow(num, num2);
Console.WriteLine(result);