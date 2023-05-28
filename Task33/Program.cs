// Задача 33: Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

//// пользователь задает число которое ищет
//// используем тип булево

Console.WriteLine("Введите количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение для элементов массива: ");
int minDigitArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для элементов массива: ");
int maxDigitArray = Convert.ToInt32(Console.ReadLine());

int[] createArray = CreateArrayRndInt(sizeArray, minDigitArray, maxDigitArray);
Console.Write("массив [");
PrintArray(createArray);
Console.WriteLine("]");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool searchDigit = SearchDigit(createArray, number);
Console.Write(searchDigit ? "Число есть в массиве." : "Числа нет в массиве.");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

bool SearchDigit(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

