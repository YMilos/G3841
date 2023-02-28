// Считываем данные с консоли
string? inputNum = Console.ReadLine();

if(inputNum!=null)
{
    // Парсим введенное число
    int number = int.Parse(inputNum);
    // Находим квадрат числа
    // int result = number*number;
    int result = (int)Math.Pow(number, 2);

    // Выводим данные в консоль
    Console.WriteLine(result);

}