

// Метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод выводит результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumSimple(int numA)
{
    int sumOfNum = 1;

    for (int i = 2; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
int res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А: ", res1);
PrintData("Сумма чисел от 1 до А: ", res2);

int SumGauss(int numA)
{
    return numA * (numA + 1) / 2;
}

