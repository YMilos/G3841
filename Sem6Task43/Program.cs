// Задача №43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//Метод считывает данные от пользователя
int ReadData(String msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}



Console.WriteLine("y = k1 * x + b1;\ny = k2 * x + b2;");
double k1 = ReadData("K1 = ");
double b1 = ReadData("B1 = ");
double k2 = ReadData("K2 = ");
double b2 = ReadData("B2 = ");
double x = (-b1 + b2) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine("Точка пересечения ({0}, {1})", x, y);
