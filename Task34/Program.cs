// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// 
Console.WriteLine("Добрый день!");
Console.WriteLine("Для решения задачи просьба ввести количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] createArray = CreateArrayRndInt(sizeArray, 100, 999);
Console.Write("[");
PrintArray(createArray);
Console.WriteLine("]");
int countEvenNumber = CountEvenNumber(createArray);
Console.WriteLine($"Количество четных чисел в массиве -> {countEvenNumber}.");
Console.WriteLine("Благодарю за внимание!");
Console.WriteLine("Доброго Вам дня!");

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

int CountEvenNumber (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}