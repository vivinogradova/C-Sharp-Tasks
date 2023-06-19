// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод. Просьба ввести натуральные числа больше 0.");
}
else if (numberM < numberN)
{
    int summOfNumberInDiapozon = SummOfNumberInDiapozon(numberM, numberN);
    Console.WriteLine($"Сумма чисел в заданном диапозоне -> {summOfNumberInDiapozon}");
}
else if (numberM > numberN)
{
    int summOfNumberInDiapozon = SummOfNumberInDiapozon(numberN, numberM);
    Console.WriteLine($"Сумма чисел в заданном диапозоне -> {summOfNumberInDiapozon}");
}
else Console.WriteLine($"Сумма чисел в заданном диапозоне -> {numberM}");



int SummOfNumberInDiapozon(int num1, int num2)
{
    if (num2 == num1) return num2;
    return num2 + SummOfNumberInDiapozon(num1, num2 - 1);
}
