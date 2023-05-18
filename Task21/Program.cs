// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки.");
Console.Write("Первая точка х:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка y:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка z:");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки.");
Console.Write("Вторая точка х:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка y:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка z:");
int zB = Convert.ToInt32(Console.ReadLine());

double distanceDot = DistanceDot(xA, yA, zA, xB, yB, zB);
double result = Math.Round(distanceDot, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3D пространстве -> {result}.");

double DistanceDot(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double square1 = (x2 - x1) * (x2 - x1);
    double square2 = (y2 - y1) * (y2 - y1);
    double square3 = (z2 - z1) * (z2 - z1);
    double squareSumm = square1 + square2 + square3;
    double distance = Math.Sqrt(squareSumm);
    return distance;
}