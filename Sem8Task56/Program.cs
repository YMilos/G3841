// Задача № 56
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Метод считывает данные из консоли
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод создает матрицу m
int[,] CreateMatrix(int m)
{
    int[,] matrix = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Random rnd = new Random();
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
// Вывод матрицы
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("\n");
    }
}
// Метод считает наименьшую сумму элементов массива
int MinSum(int[,] matrix)
{
    int min = 0;
    int count = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < min)
        {
            min = sum;
            count = i;
        }
    }
    return count;
}
// Метод выводит заданную строку матрицы
void PrintLine(int[,] matrix, int num)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[num, j] + "\t");
    }
}

int[,] matrix = CreateMatrix(ReadData("Размер квадратной матрицы: "));
PrintMatrix(matrix);
int min = MinSum(matrix);
Console.WriteLine("----------------------");
Console.WriteLine("Строка с минимальной суммой: {0}", min + 1);
Console.WriteLine("----------------------");
PrintLine(matrix, min);