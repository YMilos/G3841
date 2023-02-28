// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Считываем данные с консоли для первого числа
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли для второго числа
string? inputNum2 = Console.ReadLine();
// Считываем данные с консоли для третьего числа
string? inputNum3 = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (inputNum1 != null && inputNum2 != null && inputNum3 != null)
{
    // Парсим введенное число
    int number1 = int.Parse(inputNum1);
    // Парсим введенное число
    int number2 = int.Parse(inputNum2);
    // Парсим введенное число
    int number3 = int.Parse(inputNum3);
    // Сравниваем числа
    if (number1 > number2)
    {
        if (number1 > number3)
        {
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine(number3);
        }

    }
    else if (number2 > number3)
    {
        Console.WriteLine(number2);

    }
    else
    {
        Console.WriteLine(number3);
    }
}
