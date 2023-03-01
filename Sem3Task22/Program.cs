﻿

// Метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// Вывод нахождения степени чисел
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}

// Ввод данных
int num = ReadData("Введите N: ");

// Собираем первую строчку таблицы
string line1 = LineBuilder(num, 1);
// Собираем вторую строчку таблицы
string line2 = LineBuilder(num, 2);
//Вывод данных
PrintData(line1, line2);