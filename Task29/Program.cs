// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и 
// 2. выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение для элементов массива: ");
int minDigitArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для элементов массива: ");
int maxDigitArray = Convert.ToInt32(Console.ReadLine());

// Console.Write("[");
int[] createArray = CreateArray(sizeArray);
PrintArray(createArray);
Console.Write(" -> [");
PrintArray(createArray);
Console.Write("]");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minDigitArray, maxDigitArray);
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    
}
