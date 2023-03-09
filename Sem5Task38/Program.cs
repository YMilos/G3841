// Задача №38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Метод создает рандомный массив
int[] CreateIntArr()
{
    int[] arr = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}
// Сортировка методом вставки
int[] InsertionSort(int[] arr)
{
    int x;
    int j;
    for (int i = 1; i < arr.Length; i++)
    {
        x = arr[i];
        j = i;
        while (j > 0 && arr[j - 1] > x)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            j -= 1;
        }
        arr[j] = x;
    }
    Console.WriteLine("insertionSort");
    return arr;
}
// Сортировка методом подсчета
int[] CountingSort(int[] array)
{
    //Найдём максимальное число в массиве
    int k = array[0];
    //Максимальное число в массиве
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > k)
        {
            k = array[i];
        }
    }
    //Создадим новый массив длины k, по умолчанию наполненный нулями
    int[] tempArray = new int[k + 1];
    //Запишем в него количество вхождений каждого элемента поиндексно
    foreach (int value in array)
    {
        ++tempArray[value];
    }
    //Вставим элементы в исходный массив
    int b = 0;
    for (int i = 0; i < k + 1; ++i)
    {
        for (int j = 0; j < tempArray[i]; ++j)
        {
            array[b++] = i;
        }
    }
    Console.WriteLine("countingSort");
    return array;
}
// Метод преобразует массив в строку
void IntArrToString(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


int[] arr = CreateIntArr();
IntArrToString(arr);
Random rnd = new Random();
if (rnd.Next(0, 2) == 1)
    arr = CountingSort(arr);
else
    arr = InsertionSort(arr);
IntArrToString(arr);
Console.WriteLine(arr[arr.Length - 1] - arr[0]);