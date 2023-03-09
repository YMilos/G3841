// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

//Метод считывает данные от пользователя
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод меняет цвет элемента массива
void ChangeColor()
{
    Random rnd = new Random();
    int num = rnd.Next(0, 15);
    switch (num)
    {
        case 0: Console.ForegroundColor = ConsoleColor.Black; break;
        case 1: Console.ForegroundColor = ConsoleColor.Blue; break;
        case 2: Console.ForegroundColor = ConsoleColor.Cyan; break;
        case 3: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
        case 4: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
        case 5: Console.ForegroundColor = ConsoleColor.DarkGray; break;
        case 6: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
        case 7: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
        case 8: Console.ForegroundColor = ConsoleColor.DarkRed; break;
        case 9: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
        case 10: Console.ForegroundColor = ConsoleColor.Gray; break;
        case 11: Console.ForegroundColor = ConsoleColor.Green; break;
        case 12: Console.ForegroundColor = ConsoleColor.Magenta; break;
        case 13: Console.ForegroundColor = ConsoleColor.Red; break;
        case 14: Console.ForegroundColor = ConsoleColor.White; break;
        case 15: Console.ForegroundColor = ConsoleColor.Yellow; break;
        default: Console.ResetColor(); break;
    }
}
// Метод создает матрицу
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rnd = new Random();
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
// Печать матрицы
void PrintMatrix(int[,] matrix, int m, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
                ChangeColor();
                Console.Write(matrix[i, j] + "\t");
                Console.ResetColor();
            }
            else Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("\n");
    }
}

int pos = ReadData("Введите позицию");
int m = pos / 10;
int n = pos % 10;
int[,] matrix = CreateMatrix(4, 4);
if ((pos < 10) || (m < 0 || m > matrix.GetLength(0)) || (n < 0 || n > matrix.GetLength(1)))
{
    Console.WriteLine(pos + " - такого элемента нет");
}
PrintMatrix(matrix, m - 1, n - 1);
