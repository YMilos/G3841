 // Считываем данные с консоли
 string? inputLine = Console.ReadLine();
// // ПРоверяем, чтобы данные не были пустыми
 if(inputLine!=null)
 {
// // Создаем массив с днями недели
//     string[] weekDay = new string [7]; 
//     weekDay[0] = "Monday";
//     weekDay[1] = "Tuesday";
//     weekDay[2] = "Wednesday";
//     weekDay[3] = "Thursday";
//     weekDay[4] = "Friday";
//     weekDay[5] = "Saturday";
//     weekDay[6] = "Sunday";
// // Парсим введенное число
//     int inputNumber = int.Parse(inputLine);
// // Находим название дня недели по считанному числу
//     string outWeekDay = weekDay[inputNumber-1];
// // Выводим данные в консоль3
//     Console.WriteLine(outWeekDay);
// }
int inputNumber = int.Parse(inputLine);
 string outDayOfWeek = string.Empty;
 switch (inputNumber)
     {
         case 1: outDayOfWeek = "Monday"; break;
         case 2: outDayOfWeek = "Tuesday"; break;
         case 3: outDayOfWeek = "Wednesday"; break;
         case 4: outDayOfWeek = "Thursday"; break;
         case 5: outDayOfWeek = "Friday"; break;
         case 6: outDayOfWeek = "Saturday"; break;
         case 7: outDayOfWeek = "Sunday"; break;
         default: outDayOfWeek = "Not a day of the week!"; break;
     }
 Console.WriteLine(outDayOfWeek);

        // string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
        // Console.WriteLine(outDayOfWeek);
}