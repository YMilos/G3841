// Задача № 64
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Метод считывает данные
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(int msg1)
{
    if (msg1 == 1)
    {
        Console.Write(msg1.ToString());
    }
    else
    {
        Console.Write(msg1.ToString() + ", ");
    }
}
// Рекурсия
int Rec(int num)
{
    PrintData(num);
    if (num != 1)
    {
        Rec(num - 1);
    }
    return num;
}


Rec(ReadData("N"));