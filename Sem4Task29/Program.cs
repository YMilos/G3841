// Задача №29
// Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран.

// Метод считывает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int[] Gen1DArr(int num, int begin, int end)
// {
//     Random rnd = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(begin, end);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// int arrLen = ReadData("Введите длину массива. ");

// int[] arr = Gen1DArr(ReadData("Введите длину массива."), 
//     ReadData("Введите минимальное значение."),
//     ReadData("Введите максимальное значение."));
// Print1DArr(arr);


//Метод считывает данные от пользователя
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

string names = ReadData("Введите имена через запятую");
string[] namesArr = names.Split(",");
for (int i = 0; i < namesArr.Length; i++)
{
    namesArr[i] = namesArr[i].Trim();
}
Random rnd = new Random();
Console.WriteLine(namesArr[rnd.Next(0, namesArr.Length)]);
