using System;
using System.Text.RegularExpressions;

//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

// Метод считывает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

// Метод выводит результат пользователю
void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}

// Метод возвращает только кооржинаты точек
int[] digitsOnly(String str)
{
    // Создаем массив чисел с емкостью 6 и фильтруем строку от лишних элементов
    int[] digits = new int[6];
    char[] ch = {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', '[', ']', '{', '}',
'\\', '|', '/', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', ':', ';',
'z', 'x', 'c', 'v', 'b', 'n', 'm', '.', '?', '(', ')'};
    str = str.ToLower().Replace(';', ',').Trim(',');
    // Проверка на лишние символы
    for (int i = 0; i < ch.Length; i++)
    {
        str = str.Replace(ch[i], ' ');
    }
    // Создаем массив строк для дальнейшей работы
    String[] str2 = str.Split(",");
    if (str2.Length != 6)
    {
        // Исключаем ошибку в программе и вывод результата пользователю
        Console.WriteLine("Требуется 2 точки в 3D");
        System.Environment.Exit(0);
    }
    else
    {
        for (int i = 0; i < str2.Length; i++)
        {
            // Заполняем ранее созданный массив чисел отделением чисел из массива строк
            digits[i] = (Int32.Parse(str2[i]));
        }
    }
    // Возвращаем заполненый массив чисел
    return digits;
}

// Вычисляем расстояние между точками в 3D пространстве
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}

// Создаем массив заданых точек 
int[] coords = digitsOnly(ReadData("Введите точки"));

// Выдаем результат
PrintData("Расстояние между точками: ",
    CalcLen(coords[0], coords[3], coords[1], coords[4], coords[2], coords[5]));








