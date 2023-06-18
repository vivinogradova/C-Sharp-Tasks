// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int summOfDigit = SummOfDigit(number);
Console.WriteLine($"Сумма цифр введенного числа -> {summOfDigit}");

int SummOfDigit(int n)
{
    if (n == 0) return 0;
    return n % 10 + SummOfDigit(n / 10);
}






// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800