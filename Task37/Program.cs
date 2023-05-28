// опрелделить размер для нового массива
// сайз и определяеем сайз
// когда сайз найден создаем массив
// и потом создаем новой массив

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение для элементов массива: ");
int minDigitArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для элементов массива: ");
int maxDigitArray = Convert.ToInt32(Console.ReadLine());

int[] createArray = CreateArrayRndInt(sizeArray, minDigitArray, maxDigitArray);
Console.Write("[");
PrintArray(createArray);
Console.Write("] -> ");
int[] newArray = MultiplicatoinPairNums(createArray);
PrintArray(newArray);

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

int[] MultiplicatoinPairNums(int[] arr)
{
    int size = arr.Length / 2;
    if(arr.Length % 2 == 1) size +=1;
    int[] newArr = new int [size];

    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if(arr.Length % 2 == 1) newArr[size-1] = arr[arr.Length / 2];
    return newArr;
}