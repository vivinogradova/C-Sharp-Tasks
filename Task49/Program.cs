// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.WriteLine("Введите количество строк двумерного массива: ");
int newRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int newColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение для элементов массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите миаксимальное значение для элементов массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

int[,] newArray2d = CreateMatrixRndInt(newRows, newColumns, minimum, maximum);
Console.WriteLine("Вновь созданный массив, согласно введенным параметрам: ");
PrintMatrix(newArray2d);
Console.WriteLine();
SquareElementsWithEvenIndex(newArray2d);
Console.WriteLine("Этот же массив, с квадратами элементов с четными индексами: ");
PrintMatrix(newArray2d);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLenght(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength(1)
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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

int[,] SquareElementsWithEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}