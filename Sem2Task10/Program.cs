
int number = int.Parse(Console.ReadLine() ?? "0");
if ((number > 99) && (number < 1000))
{
    int result = number / 10 % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ведите число от 100 до 999.");
}
