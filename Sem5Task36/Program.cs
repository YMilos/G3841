// Задача № 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Метод создает рандомный массив
int[] CreateIntArr()
{
    int[] arr = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}
// Метод находит сумму элементов
int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
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
// Метод находит парные элементы массива
void Pair(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            Console.WriteLine("Пара: " + arr[i] + "\n" +
                "Индексы: " + i + ", " + (i + 1));
            count++;
        }
    }
    if (count == 0) Console.WriteLine("Одинаковых чисел нет");
    else Console.WriteLine("Всего пар:" + count);
}

int[] arr = CreateIntArr();
arr = BubbleSort(arr);
IntArrToString(arr);
Pair(arr);
Console.WriteLine(Sum(arr));