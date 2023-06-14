// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2  
// 5 9 2 3  
// 8 4 2 4  
// 5 2 6 7  
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] createMatrix = CreateMatrixRndInt(3, 4, 1, 99);
Console.WriteLine("Задан прямоугольный двумерный массив:");
PrintMatrix(createMatrix);
Console.WriteLine();
Console.WriteLine("Одномерный массив состоящий из сумм строк двумерного массива:");
int[] arraySummRows = ArraySummRows(createMatrix);

// PrintArray(arraySummRows); // для проверки корректности расчетов
// Console.WriteLine(); // // для проверки корректности расчетов

int numberRowsWithMinimalSummElements = NumberRowsWithMinimalSummElements(arraySummRows);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberRowsWithMinimalSummElements} строка.");


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[] ArraySummRows(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int sum = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[n] = sum;
        n++;
        sum = 0;
    }
    return array;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int NumberRowsWithMinimalSummElements(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index+=1;
}


