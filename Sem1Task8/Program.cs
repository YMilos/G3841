// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Считываем данные с консоли 
string? inputNum1 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if (inputNum1 != null)
{
    // Парсим введенное число
    int number1 = int.Parse(inputNum1);
    // Добавляем пустую строку, для вывода четных чисел
    string evenNumber = String.Empty;

    for (int i = 2; i < number1; i = i + 2)
    {
        evenNumber = evenNumber + i + ", ";
    }

    if (number1 % 2 == 0)
    {
        evenNumber = evenNumber + number1;
    }
    else
    {
      evenNumber =  evenNumber.Remove(evenNumber.Length - 2);
    }
    Console.WriteLine(evenNumber);
}