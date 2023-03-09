// Задача № 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Метод создает трехмерный массив
int[,,] Create_3D_Massive(int size1, int size2, int size3)
{
    Random random = new Random();
    int[,,] array = new int[size1, size2, size3];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                int next;
                do
                {
                    next = random.Next(10, 99);
                } while (NotSame(array, next));
                array[i, j, k] = next;
            }
        }
    }
    return array;
}
// Метод проверяет на наличие одинаковых элементов в массиве
Boolean NotSame(int[,,] arr, int indexOf)
{
    for (int p = 0; p < arr.GetLength(0); p++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                int[] newArr = new int[arr.GetLength(2)];
                for (int k = 0; k < newArr.Length; k++)
                {
                    newArr[k] = arr[p, i, j];
                }
                if (Array.IndexOf(newArr, indexOf) != -1)
                {
                    return true;
                }
            }
        }
    }
    return false;

}
// Метод выводит массив
void PrintMassive(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine(array[i, j, k] + " ({0},{1},{2})", i, j, k);
            }
        }
    }
}

PrintMassive(Create_3D_Massive(2, 2, 2));