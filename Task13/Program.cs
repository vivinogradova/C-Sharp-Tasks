// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Реализация без использования метода:
// 1. если отрицательное число - меняем знак
// 2. если меньше 100 - сообщаем что третьей цифры нет
// 3. все остальное - "крутим" цикл до трехзначного числа
// 4. получаем третью цифру - остатьк от деления на 10 и выводим в консоль
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0) number *= -1;
// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры  в заданном числе нет.");
//     return;
// }
// else
// {
//     while (number > 1000)
//     {
//         number = number / 10;
//     }
// }
// int result = number % 10;
// Console.WriteLine($"Третья цифра заданного числа -> {result}.");

// Реализация с использованием метода:
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number < 100)
{
    Console.WriteLine("Третьей цифры  в заданном числе нет.");
    return;
}
while (number > 1000)
     {
        number = number / 10;
     }
int result = ThirdDigit (number);
int ThirdDigit (int num)
{
    int thirdDigit = num % 10;
    return thirdDigit;
}
Console.WriteLine($"Третья цифра заданного числа -> {result}.");
