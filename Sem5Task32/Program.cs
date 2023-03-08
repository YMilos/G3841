

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

//Метод инвертирует созданный массив
void InvArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

//Метод создает новый инвертированный массив из уже созданного массива
int[] InvArrNew(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i] * -1;
    }
    return newArr;
}


int[] testArr = Gen1DArray(12, -9, 9);
Print1DArr(testArr);
InvArr(testArr);
int[] testArrNew = InvArrNew(testArr);
Print1DArr(testArr);