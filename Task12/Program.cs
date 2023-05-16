// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. 
// Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder (number1, number2);

// мое решение:
//
// if (remainder == 0)
// {
//     Console.WriteLine("Первое число кратно второму числу.");
// }
// else 
// {
//     Console.WriteLine($"Первое число не кратно второму числу, остаток от деления {remainder}.");
// }

// решение в группе:

string result = remainder != 0 ? $"не кратно, остаток = {remainder}." : "кратно";
Console.WriteLine(result);

int Remainder (int a, int b)
{
    return a % b;
}
