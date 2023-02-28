
int num1 = int.Parse(Console.ReadLine() ?? "0");
int result1 = num1 % 7;
int result2 = num2 % 23;
if ((result1 == 0) && (result2==0))
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно ");
}