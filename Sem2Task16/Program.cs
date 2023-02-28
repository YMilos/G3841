
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

TestSQRT(num1, num2);
TestSQRT(num2, num1);
// if (num1 * num1 == num2)
// {
//     Console.WriteLine(num2 + " квадрат " + num1);
// }
// else if (num2 * num2 == num1)
// {
//     Console.WriteLine(num1 + " квадрат " + num2);
// }
// else
// {
//     Console.WriteLine("Не квадрат");
// }


void TestSQRT(int i, int j)
{
    if ((int)Math.Pow(num1, 2) == num2)
    {
        Console.WriteLine("Да, число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("Нет, число " + j + " не является квадратом числа " + i);
    }
}
