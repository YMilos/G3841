// Задача №48
// Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ =m+n. Выведите полученный массив на экран.

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] CreateArray(int countRow, int countColumn)
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

void ShowArray(int[,] arr)
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = CreateArray(xlen, ylen);
ShowArray(matrix);
