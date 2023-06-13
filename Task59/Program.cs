// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] createMatrix = CreateMatrixRndInt(4, 4, 1, 9);
Console.WriteLine("Задан массив:");
PrintMatrix(createMatrix);
Console.WriteLine();
int[] pos = FindMinElement(createMatrix);
int min = pos[2];
Console.WriteLine($"Наименьший элемент => {min}");
Console.WriteLine();
Console.WriteLine("Следующий массив:");
int[,] newMatrix = DeleteRowsColumsMinElement(createMatrix, pos[0], pos[1]);
PrintMatrix(newMatrix);

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

int[] FindMinElement(int[,] mtr)
{
    int min = mtr[0, 0];
    int position1 = 0;
    int position2 = 0;
    for (int i = 0; i < mtr.GetLength(0); i++)
    {
        for (int j = 1; j < mtr.GetLength(1); j++)
        {
            if (mtr[i, j] < min)
            {
                min = mtr[i, j];
                position1 = i;
                position2 = j;
            }

        }
    }
    return new int[] { position1, position2, min };
}

int[,] DeleteRowsColumsMinElement(int[,] matrix, int rows, int colums)
{
    int size1 = matrix.GetLength(0) - 1;
    int size2 = matrix.GetLength(1) - 1;
    int[,] newMatrix = new int[size1, size2];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == rows) m += 1;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == colums) n += 1;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newMatrix;
}
