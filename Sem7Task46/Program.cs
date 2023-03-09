// Задача №46
// Задайте двумерный массив размером m*n, заполненный случайными целыми числами

// Console.WriteLine("Количество строк матрицы");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Количество столбцов матрицы");
// int ь = int.Parse(Console.ReadLine());
// System.Random numberSyntezator = new System.Random();
// int i = 0; int j = 0;
// int[,] outArray = new int[n, m];
// while (i < countRow)
// {
//     j = 0;
//     while (j < countRow)
//     {
//         outArray[i, j] = numberSyntezator.Next(0, 101);
//         j++;
//     }
//     i++;
// }

// i = 0; j = 0;
// while (i < n)
// {
//     j = 0;
//     while (j < m)
//     {
//         Console.Write(outArray[i, j] + " ");
//         j++;
//     }
//     i++;
//     Console.WriteLine();
// }

// 1) Получение данных от пользователя
int n = InputNum("Количество строк матрицы ");
int m = InputNum("Количество столбцов матрицы ");
// 2) Генерация двумерного массива
int[,] matrix = FillTwoDimArray(n, m);
// 3) Печатаем двумерный массив
PrintTwoDimArray(matrix);

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        Console.WriteLine();
        i++;

    }
}

