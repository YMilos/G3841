
// System.Random numSintezator = new System.Random();
// int digit = numSintezator.Next(100, 1000);
// Console.WriteLine(digit);
// int digitFirst = digit / 100;
// int digitLast = digit % 10;
// Console.WriteLine(digitFirst * 10 + digitLast);

System.Random random = new System.Random();
int randomNumber = random.Next(100, 1000);
Console.WriteLine("Число: " + randomNumber);
string value = randomNumber.ToString();
char[] numberArray = value.ToCharArray();
Console.WriteLine(numberArray[0] + "" + numberArray[2]);