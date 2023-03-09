// Задача №44
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод преобразования десятичных в двоичную
string FromDecToBin(int num)
{
    string result = string.Empty;
    while (num >= 1)
    {
        result = result + Convert.ToString(num % 2);
        num = num / 2;
    }
    return result;
}
string result = FromDecToBin(ReadData("Введите число: "));
Console.WriteLine(result);