// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] newArray2d = CreateMatrixRndInt(4, 4, 1, 9);
Console.WriteLine("Задан массив: ");
PrintMatrix(newArray2d);
double[] average = Average(newArray2d);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArrayDouble(average);

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

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}.");
    }
}

double[] Average(int[,] matr)
{
    int size = matr.GetLength(1);
    double[] arr = new double[size];
    for (int d = 0; d < arr.Length;)
    {
        for (int j = 0; j < matr.GetLength(1);)
        {
            double sum = 0;
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                Math.Round(sum += matr[i, j], 1);
            }
            arr[d] = Math.Round(sum / matr.GetLength(0), 1);
            d++;
            j++;
        }
    }
    return arr;
}

