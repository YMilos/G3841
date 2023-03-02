

// Метод считывает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Создание горизонтальных границ
string corner(int length)
{
    string str = "";
    for (int i = 0; i < length; i++)
    {
        str += "--------";
    }
    return str;
}

//создание итоговой таблицы
void TableBuilder(int num)
{
    string line1 = LineBuilder(num, 1);
    string corners = corner(num);
    string line2 = LineBuilder(num, 3);
    Console.WriteLine(corners);
    Console.WriteLine(line1);
    Console.WriteLine(corners);
    Console.WriteLine(line2);
    Console.WriteLine(corners);
}

// Вывод нахождения степени чисел
string LineBuilder(int n, int p)
{
    string s = "| ";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t" + "| ";
    }
    s.Trim(' ');
    return s;
}

// Ввод данных
int num = ReadData("Введите N: ");
TableBuilder(num);
