// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки.");
Console.Write("Первая точка х:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка y:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки.");
Console.Write("Вторая точка х:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка y:");
int yB = Convert.ToInt32(Console.ReadLine());

double distanceDot = DistanceDot(xA, yA, xB, yB);
double result = Math.Round(distanceDot, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и B в 2D пространстве -> {result}.");

double DistanceDot(int x1, int y1, int x2, int y2)
{
    double square1 = (x2 - x1) * (x2 - x1);
    double square2 = (y2 - y1) * (y2 - y1);
    double squareSumm = square1 + square2;
    double distance = Math.Sqrt(squareSumm);
    return distance;
}

