// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Просьба ввести первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numberВ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());
bool isTriangle = IsTriangle(numberA, numberВ, numberС);
Console.WriteLine(isTriangle ? "Треугольник с такими сторонами может существовать."
                            : "Треугольник с такими сторонами не может существовать.");

bool IsTriangle(int a, int b, int c)
{
    return a + b > c && b + c > a && a + c > b;
    
}

