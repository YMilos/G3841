

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");
int result = num2 % num1;
if (result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно " + result);
}