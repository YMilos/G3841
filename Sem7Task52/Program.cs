// Задача № 52
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
void PrintMatrix(int[,] matrix)
{
    int d1 = 0;
    int d2 = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == d1 && j == d2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix[i, j] + "\t");
                d2 += 2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[i, j] + "\t");
            }
        }
        if (d2 % 2 == 0) { d2 = 1; }
        else { d2 = 0; }
        d1++;
        Console.Write("\n");
    }
    Console.ResetColor();
}

int[,] matrix = CreateMatrix(5, 5);
PrintMatrix(matrix);