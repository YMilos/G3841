// Задача 41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод считывает данные от пользователя
int ReadData(String msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод создает рандомный массив
int[] CreateIntArr()
{
    int[] arr = new int[ReadData("Введите размер массива: ")];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadData("Введите элемент массива: ");
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
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Чисел больше нуля: {0}", count);