
int positivSum = 0;
int negotivSum = 0;

int[] testArr = Gen1DArray(12, -9, 9);
NegPosSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", positivSum);
PrintData("Сумма отрицательных чисел в массиве: ", negotivSum);

// Метод выводит результат пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод генерирует и заполняет массив случайными числами от минимального до максимального
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод выводит в консоль массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void NegPosSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negotivSum += arr[i];
        }
    }
}