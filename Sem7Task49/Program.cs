// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты

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

void Update2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = (int)Math.Pow(arr[i, j], 2);
        }
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
Update2DArr(matrix);
Print2DArr(matrix);
