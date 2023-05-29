// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] createArrayRndInt = CreateArrayRndInt(5, 1, 9);
Console.Write("[");
PrintArray(createArrayRndInt);
Console.Write("] -> ");
Console.Write("[");
int[] newArray = CopyArray(createArrayRndInt);
// newArray[0]= 1000; // добавили для проверки
PrintArray(newArray, ":");
Console.Write("]");

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

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int[] CopyArray(int[] arr)
{
    int[] newarryay = new int [arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newarryay[i] = arr[i];
    }
    return newarryay;
}