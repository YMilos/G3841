// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.

// Метод считывает данные от пользователя 
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Записываем введенное значение для последующей сверки
int checkNum = ReadData("Введите число: ");

// Объявляем словарь для палиндромов
Dictionary<int, string> palindrom = new Dictionary<int, string>() { };
PalindromIntroduction(palindrom);

// Метод для заполнения словаря палиндромами
Dictionary<int, string> PalindromIntroduction(Dictionary<int, string> palNum)
{
    // Добавляем цикл для написания первой половины палиндрома
    // и разворачиваем, преобразуя в строку
    for (int i = 1; i < 100; i++)
    {
        // Создаем пустую строку для записи значений
        string result = string.Empty;
        string firstSideNum = i.ToString();
        char[] secondSideNum = firstSideNum.ToCharArray();
        Array.Reverse(secondSideNum);
        string str = new string(secondSideNum);
        // Добавляем число "Зеркало" для палиндрома, объединяем значения и записываем в словарь
        for (int j = 0; j <= 10; j++)
        {
            // Если "Зеркало" не нужно или нужно
            if (j == 10)
            {
                result = firstSideNum + str;
            }
            else
            {
                result = firstSideNum + j.ToString() + str;
            }
            palNum.Add(Int32.Parse(result), "Введеное значение является палиндромом");
        }
    }
    // Возвращаем готовый словарь
    return palNum;
}

// Проверяем введенное пользователем значение со словарем и вывод результата
if (palindrom.ContainsKey(checkNum))
{
    Console.WriteLine(palindrom[checkNum]);
}
else
{
    Console.WriteLine("Введенное значение не является палиндромом!");
}