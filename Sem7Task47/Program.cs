// Задача №47
// Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

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
// // Метод  создает число с двумя знаками после запятой
// float NextFloat(float min, float max){
//   Random random = new Random();
//   double val = (random.NextDouble() * (max - min) + min);
//   return (float)val;
// }

//Метод выбирает значение
double GetRandomNumber(double minimum, double maximum)
{
    Random random = new Random();
    double num = random.NextDouble() * (maximum - minimum) + minimum;
    double truncated = Math.Truncate(num * 100) / 100;
    return truncated;
}
// Метод создает матрицу
double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = GetRandomNumber(-5, 5);
        }
    }
    return matrix;
}
// Печать матрицы
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            ChangeColor();
            Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("\n");
    }
}

double[,] matrix = CreateMatrix(ReadData("M = "), ReadData("N = "));
PrintMatrix(matrix);

//Console.ResetColor() 