// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Palindrome(int num)
{
    if(num < 10000 || num >= 100000)   
    {
        Console.WriteLine("Введённое число не является пятизначным");
    }
    else
    {
        int dig1 = num / 10000;
        int dig2 = num / 1000 % 10;
        int dig4 = num % 100 / 10;
        int dig5 = num % 10;
        if(dig1 == dig5 || dig2 == dig4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    return num;
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
Palindrome(number);