// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int CubeTable(int num)
{
    if(num < 1)
    {
        Console.WriteLine("Введённое число не соответствует условию задачи");
    }
    else
    {
        int index = 1;
        Console.Write("Таблица кубов:");
        while(index <= num)
        {
            int cube = index * index * index;
            Console.Write(" " + cube);
            index = index + 1;
        }
    }
    return num;
}

Console.WriteLine("Введите число не менее 1:");
int number = int.Parse(Console.ReadLine());
CubeTable(number);