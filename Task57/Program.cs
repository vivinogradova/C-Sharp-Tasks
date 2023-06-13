// Задача 57: Составить частотный словарь элементов
// двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
//
// Набор данных               Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
//                            1 встречается 1 раз
//                            2 встречается 1 раз
//                            8 встречается 1 раз
//                            9 встречается 3 раза
//
// 1, 2, 3              1 встречается 3 раза
// 4, 6, 1              2 встречается 2 раз
// 2, 1, 6              3 встречается 1 раз
//                      4 встречается 1 раз
//                      6 встречается 2 раза

int[,] createMatrix = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(createMatrix);
Console.WriteLine();
int[] array = MatrixToArray(createMatrix);
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountNumbersArray(array);

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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[n] = matrix[i, j];
            n++;
        }
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

void CountNumbersArray(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"число {num} встречается {count} раз.");
            num = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"число {num} встречается {count} раз.");
}
