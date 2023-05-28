// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Добрый день!");
Console.WriteLine("По условиям задачи, настоящая программа создаст одномерный массив из 123 случайных чисел в заданном Вами числовом диапозоне.");
Console.WriteLine("Просьба ввести минимальное значение для элементов массива: ");
int minDigitArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И максимальное: ");
int maxDigitArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(123, minDigitArray, maxDigitArray);
Console.Write("Массив [");
PrintArray(array);
Console.WriteLine("]");

Console.WriteLine("Далее, по условиям задачи, требуется найти количество элементов массива, значения которых лежат в заданном Вами числовом отрезке.");
Console.WriteLine("Просьба ввести минимальное значение для числового отрезка: ");
int minDigit= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И максимальное: ");
int maxDigit = Convert.ToInt32(Console.ReadLine());

int countTwo = CountTwoDigitsNums(array, minDigit, maxDigit);
Console.WriteLine($"Количество элементов массива, значения которых лежат в заданном Вами числовом отрезке от {minDigit} до {maxDigit} -> {countTwo}.");
Console.WriteLine("Спасибо за внимание!");
Console.WriteLine("Доброго дня!");

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

int CountTwoDigitsNums(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max) count++;
    }
    return count;
}