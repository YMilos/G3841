// Задача № 58
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

// Метод перемножает матрицы
static int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int m1rows = matrix1.GetLength(0);
    int m1cols = matrix1.GetLength(1);
    int m2rows = matrix2.GetLength(0);
    int m2cols = matrix2.GetLength(1);

    if (m1cols != m2rows)
    {
        throw new Exception("Неверные размеры матриц");
    }

    int[,] result = new int[m1rows, m2cols];

    for (int i = 0; i < m1rows; i++)
    {
        for (int j = 0; j < m2cols; j++)
        {
            for (int k = 0; k < m1cols; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}


int[,] matrix1 = CreateMatrix(3);
int[,] matrix2 = CreateMatrix(3);
PrintMatrix(matrix1);
Console.WriteLine("—————— X ——————");
PrintMatrix(matrix2);
Console.WriteLine("—————— === ——————");
PrintMatrix(Multiply(matrix1, matrix2));