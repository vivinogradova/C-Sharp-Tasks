// Задача 50. Напишите программу, которая на вход 
// 1. принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позиции элемента массива: ");
Console.WriteLine("Позиция строки: ");
int inComeRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И столбца: ");
int inComeColumns = Convert.ToInt32(Console.ReadLine());
if (inComeRows < 0 || inComeColumns < 0) Console.WriteLine("Некорректный ввод. Позиции элемента массива не могут быть отрицательными.");
else
{
int[,] newArray2d = CreateMatrixRndInt(4, 4, 1, 9);
Console.WriteLine("Задан массив: ");
PrintMatrix(newArray2d);
bool isElementInMatrix = IsElementInMatrix(newArray2d, inComeRows, inComeColumns);
Console.WriteLine(isElementInMatrix ? $"Значение элемента = {newArray2d[inComeRows, inComeColumns]}."
                                    : $"{inComeRows}, {inComeColumns} -> такого элемента в массиве нет.");
}

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

bool IsElementInMatrix(int[,] matr, int rows, int columns)
{
    return matr.GetLength(0) >= rows && matr.GetLength(1) >= columns;
}