//  Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число:");
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberС > max) max = numberС;
Console.WriteLine($"Максимальное из введенных Вами число {max}.");