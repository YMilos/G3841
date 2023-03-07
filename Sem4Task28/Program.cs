using System.Numerics;

// Метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

BigInteger CalcFact(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}

int number = ReadData("Введите число А: ");

BigInteger fact = CalcFact(number);

PrintData("Факториал равно: ", fact);