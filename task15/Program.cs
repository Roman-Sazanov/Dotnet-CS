int FindWeekDay(int num)
{
    if(num < 1 || num > 7)
    {
        Console.WriteLine("Число не является днём недели");
    }
    else if(num >= 1 && num <= 5)
    {
        Console.WriteLine("Рабочий день");
    }
    else if(num >= 6 && num <= 7)
    {
        Console.WriteLine("Выходной день");
    }
    return num;
}

Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine());
FindWeekDay(number);