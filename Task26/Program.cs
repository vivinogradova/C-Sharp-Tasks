// Задача 26: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0) number *= -1;
int quantityDigit = QuantityDigit(number);
Console.WriteLine($"В числе {number}, количество цифр => {quantityDigit}.");
int QuantityDigit (int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
    