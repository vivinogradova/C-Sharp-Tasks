// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] createMatrix1 = CreateMatrixRndInt(3, 4, 1, 9);
int[,] createMatrix2 = CreateMatrixRndInt(4, 3, 1, 9);
Console.WriteLine("Даны матрицы:");
PrintMatrix(createMatrix1);
Console.WriteLine();
PrintMatrix(createMatrix2);
Console.WriteLine();
if (createMatrix1.GetLength(1) != createMatrix2.GetLength(0))
{
    Console.WriteLine("Получить произведение таких матриц невозможно.");
    Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй.");
}
else
{
    int[,] multiplicationMatrix = MultiplicationMatrix(createMatrix1, createMatrix2);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(multiplicationMatrix);
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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                resultMatrix[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return resultMatrix;
}
