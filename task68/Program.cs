// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int AckermanFunction(int num1, int num2)
{    
    if(num1 == 0)
    {
        return num2 + 1;
    }
    else if (num1 > 0 && num2 == 0)
    {
        return AckermanFunction(num1 - 1, 1);
    }
    else
    {
        return AckermanFunction(num1 - 1, AckermanFunction(num1, num2 - 1));
    }
}

Console.Clear();
int number1 = Prompt("Введите число M:");
int number2 = Prompt("Введите число N:");
Console.WriteLine($"Функция Аккермана: {AckermanFunction(number1, number2)}");