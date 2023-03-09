// Задача № 54
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Метод создает матрицу m*n
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
// Сортировка массива методом пузырька
int[] BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}
// Сортировка матрицы
int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] arr = new int[matrix.GetLength(1)];
        for (int k = 0; k < arr.Length; k++)
        {
            arr[k] = matrix[i, k];
        }
        BubbleSort(arr);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = arr[j];
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

int[,] matrix = CreateMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine("—————————————————————");
SortMatrix(matrix);
PrintMatrix(matrix);