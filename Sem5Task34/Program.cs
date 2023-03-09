// Задача №34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int[] arr = CreateIntArr();
IntArrToString(arr);
arr = BubbleSort(arr);
IntArrToString(arr);
// Вывод колличества четных элементов массива
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) count += 1;
}
Console.WriteLine(count);