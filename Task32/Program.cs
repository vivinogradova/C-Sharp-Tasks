// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// используем печать массива
// используем войд потому что работаем внутри массива, нет необходимости возвращать массив


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
InverseArray(createArray);
Console.Write("[");
PrintArray(createArray);
Console.WriteLine("]");


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

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

void PrintArray(int[] arra)
{
    for (int i = 0; i < arra.Length; i++)
    {
        if(i < arra.Length -1) Console.Write($"{arra[i]}, ");
        else Console.Write($"{arra[i]}");
    }
}
