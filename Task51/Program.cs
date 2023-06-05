// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
int sumMainDiagonal = SumMainDiagonal(newArray2d);
Console.WriteLine($"Сумма элементов главной диагонали = {sumMainDiagonal}");

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

int SumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    // int size = matrix.GetLength(0) > matrix.GetLength(1) ? matrix.GetLength(1) : matrix.GetLength(0);

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}