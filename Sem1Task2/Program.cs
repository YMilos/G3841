// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Считываем данные с консоли для первого числа
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли для второго числа
string? inputNum2 = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (inputNum1 != null && inputNum2 != null)
{
    // Парсим введенное число
    int number1 = int.Parse(inputNum1);
    // Парсим введенное число
    int number2 = int.Parse(inputNum2);
    // Сравниваем числа
    if (number1 > number2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else if (number1 == number2)
    {
        Console.WriteLine("Введенные числа равны");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }

}
