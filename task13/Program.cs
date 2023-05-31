// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int FindThirdDigit(int td)
{
    if(td < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return 0;
    }
    else if(td > 999)
    {
        while(td > 999)
        {
            td /= 10;
        }
        Console.Write("Третья цифра: " + td % 10);
        return td % 10;
    }
    else
    {
        int result2 = td % 10;
        Console.WriteLine("Третья цифра: " + result2);
        return result2;
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
FindThirdDigit(number);