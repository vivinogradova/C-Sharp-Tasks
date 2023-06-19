// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 || numberN < 0) Console.WriteLine("Некорректный ввод. Просьба ввести неотрицательные числа.");
else
{
    int akkermanFunc = AkkermanFunc(numberM, numberN);
    Console.WriteLine($"Результатом вычисления функции Аккермана, где m = {numberM} n = {numberN} -> A (m, n) = {akkermanFunc}");
}


int AkkermanFunc(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AkkermanFunc(n - 1, 1);
    return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
}