// Считываем данные с консоли для первого числа
string? inputNum1 = Console.ReadLine();
// Считываем данные с консоли для второго числа
string? inputNum2 = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(inputNum1!=null && inputNum2!=null)
{
    // Парсим введенное число
    int number1 = int.Parse(inputNum1);
    // Парсим введенное число
    int number2 = int.Parse(inputNum2);

    if(number1 == number2*number2)
    {
        Console.WriteLine("Первое число квадрат второго!");
    }
    else
    {
        Console.WriteLine("Первое число не квадрат второго!");
    }


}