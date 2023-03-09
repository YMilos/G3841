// Задача № 66
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Метод считывает данные
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод суммирует элементы
int Sum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + Sum(m + 1, n);
    }
}

Console.WriteLine(Sum(ReadData("M"), ReadData("N")));