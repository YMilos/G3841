// Задача № 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Метод считывает данные
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Функция Аккермана
int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
    return -1;
}

Console.WriteLine("Введите параметры для функции Аккермана:");
int m = ReadData("m = ");
int n = ReadData("n = ");
Console.WriteLine("A({0}, {1}) = {2}", m, n, AkkermanFunc(m, n));