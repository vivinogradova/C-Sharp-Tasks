// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] createArrayRndDouble = CreateArrayRndDouble(5, 0, 100);
Console.Write("[");
PrintArrayDouble(createArrayRndDouble, ";");
Console.WriteLine("] -> ");
double minDigitArray = MinDigitArray(createArrayRndDouble);
double maxDigitArray = MaxDigitArray(createArrayRndDouble);
double diffirenceMinMaxDigitArray = DiffirenceMinMaxDigitArray(minDigitArray, maxDigitArray);
Console.WriteLine($"-> Разницу между максимальным ({maxDigitArray}) и минимальным ({minDigitArray}) элементами массива => {diffirenceMinMaxDigitArray}.");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MinDigitArray(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return Math.Round(min, 1);
}

double MaxDigitArray(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return Math.Round(max, 1);
}

double DiffirenceMinMaxDigitArray(double min, double max)
{
    double result = max - min;
    return Math.Round(result, 1);
}