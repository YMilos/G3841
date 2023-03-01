//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//string? num = Console.ReadLine("Введите число: ");

int number = int.Parse(Console.ReadLine() ?? "0");

int count = 1;
int i = number;
// вводим переменные как счетчики
while (i / 10 != 0)
{
    i /= 10;
    count++;
}
// узнаем колличество цифр введенных в терминале
if (count >= 3)
{
    // Оставляю первые 3 цифры и явно преобразую в int
    double result = number / Math.Pow(10, count - 3);
    int result1 = (int)result;
    // Выводим результат требуемую цифру
    Console.WriteLine(result1 % 10);
}
else
{
    // Если цифр меньше
    Console.WriteLine("Третьей цифры нет.");
}
