﻿// 9. Напишите программу, которая выводит
// 1. случайное число 
// 2. из отрезка [10, 99] и показывает
// 3. наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10, 99+1
Console.WriteLine ($"Случайное число из отрезка 10 -99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit (int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

