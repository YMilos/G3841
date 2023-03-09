// Задача №25
// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

// Метод считывает данные от пользователя
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(int msg1)
{
    Console.WriteLine(msg1.ToString());
}
// Возводит в степень
int Power(int number, int pow)
{
    int res = 1;
    for (int i = 0; i < pow; i++)
    {
        res *= number;
    }
    return res;
}
// Сумма
int Sum(int a, int b)
{
    return a + b;
}
// Вычитание
int Sub(int a, int b)
{
    return a - b;
}
// Деление
int Division(int a, int b)
{
    return a / b;
}
// Умножение
int Multiply(int a, int b)
{
    return a * b;
}

int a = ReadData("Введите число");
Console.WriteLine("Введите оператор");
string sign = Console.ReadLine() ?? "0";
int b = ReadData("Введите второе число");
// Проверка знака операции и вывод
switch (sign)
{
    case ("^"):
        PrintData(Power(a, b));
        break;
    case ("+"):
        PrintData(Sum(a, b));
        break;
    case ("-"):
        PrintData(Sub(a, b));
        break;
    case ("*"):
        PrintData(Multiply(a, b));
        break;
    case ("/"):
        PrintData(Division(a, b));
        break;
    default:
        Console.WriteLine("Неверный оператор (^; +; -; *; /)");
        break;
}
