
void PrintData(string res)
{
    Console.WriteLine(res);
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

int CountElement(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n > 10 && n < 99);
}

int[] testArr = Gen1DArray(123, 0, 1000);
Print1DArr(testArr);
int count = CountElement(testArr);
PrintData("Количество элементов в отрезке [10,99] : " + count);