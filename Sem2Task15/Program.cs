// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Считываем цифру
int dayNumber = int.Parse(Console.ReadLine() ?? "0");
// Заводим словарь со значениями дней недели согласно задаче
Dictionary<int, string> dayofWeek = new Dictionary<int, string>()
{
    {1, "Monday is working day."},
    {2, "Tuesday is working day."},
    {3, "Wednesday is working day."},
    {4, "Thursday is working day."},
    {5, "Friday is working day."},
    {6, "Saturday day off"},
    {7, "Sunday day off"},
};
// Прописываем условие работы программы
if((dayNumber>7) || (dayNumber<1))
{
    Console.WriteLine("Not a day of the week.");
}
else
{
    Console.WriteLine(dayofWeek[dayNumber]);
}