// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Если попробовать прировнять по y (надеюсь, что правильно поняла преподавателя)
// 1. Приравниваем два уравнения:
//    k1 * x + b1 = k2 * x + b2; // далее выражение k1 * x записываю как x * k1 и k2 * x, как x * k2
// 2. Переносим влево части уравнения с x:
//    x * k1 - x * k2 = b2 - b1;
// 3. Выражения x * k1 и - x * k2 можно записать как x * (k1 - k2) 
//    x * (k1 - k2) = b2 - b1;
// 4. Таким образом x - множитель; (k1 - k2) - множитель; b2 - b1 - произведение
//    получаем множитель как результат деления произведения на второй множитель
//    х = (b2 - b1) / (k1 - k2)

Console.WriteLine("Ведите значение B1:");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите значение K1:");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите значение B2:");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите значение K2:");
double K2 = Convert.ToInt32(Console.ReadLine());

double xCoordinate = FindX(B1, K1, B2, K2);
double yCoordinate = FindY(xCoordinate, B1, K1);
Console.WriteLine($"({xCoordinate};{yCoordinate})");

double FindX (double b1, double k1, double b2, double k2)
{
    double numX = (b2 - b1) / (k1 - k2);
    return Math.Round(numX, 1);
}

double FindY(double x, double b, double k)
{
    double numY = k * x + b;
    return Math.Round(numY, 1);
}
