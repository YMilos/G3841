// Задача №27
// Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.

// Метод считывает данные от пользователя
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg);
    Console.WriteLine(res);
}

int digit(int num)
{
    int res = 0;
    while (num != 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}


DateTime d1 = DateTime.Now;
int res1 = digit(ReadData("Введите число"));
PrintData("Вариант (Digit): ", res1);
Console.WriteLine("Программа выполнена за: " + (DateTime.Now - d1));