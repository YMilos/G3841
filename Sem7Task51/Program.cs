﻿// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int countRow, int countColumn)
{
    int[,] arr = new int[countColumn, countRow];
    for (int i = 0; i < countColumn; i++)
    {
        for (int j = 0; j < countRow; j++)
        {
            arr[i, j] = j * i;
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j < arr.GetUpperBound(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int DiagSum(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);

    for (int i = 0; i < min; i = i + 2)
    {
        res = res + arr[i, i];
    }
    return res;
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
int sumOfDiagonal = DiagSum(matrix);
Console.WriteLine(sumOfDiagonal);
