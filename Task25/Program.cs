// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и
// 2. возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0) Console.WriteLine("Некорректный ввод,просьба ввести целое положительное число.");
else
{
    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {exponentiation}.");
    int Exponentiation(int numA, int numB)
    {
        int expo = 1;
        for (int i = 0; i < numB; i++)
        {
            expo = expo * numA;
        }
        return expo;
    }
}