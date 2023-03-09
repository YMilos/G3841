// Задача №40
// Напишите программу, которая принимает на вход 
// три числа и проверяет, может ли существовать 
// треугольник со сторонами такой длины

int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

if (a + c > b && a + b > c && b + c > a)
{
    Console.WriteLine("Треугольник может быть построен.");
}
else
{
    Console.WriteLine("Треугольник не может быть построен.");
}

