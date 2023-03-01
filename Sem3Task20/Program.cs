﻿

// Метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}
// Вычисляем расстояние между точками в 2D пространстве
double CalcLen(int x1, int x2, int y1, int y2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}

// Вводим координаты точек
// int coordX1 = ReadData("Введите координату X1: ");
// int coordX2 = ReadData("Введите координату X2: ");
// int coordY1 = ReadData("Введите координату Y1: ");
// int coordY2 = ReadData("Введите координату Y2: ");

// // Вычисляем длину
// double len = CalcLen(coordX1, coordX2, coordY1, coordY2);

// // Выдаем результат
// PrintData("Расстояние между точками: ", len);
PrintData("Расстояние между точками: ", CalcLen(
    ReadData("Введите координату X1: "),
    ReadData("Введите координату X2: "),
    ReadData("Введите координату Y1: "),
    ReadData("Введите координату Y2: ")));