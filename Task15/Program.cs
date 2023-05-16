// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());
if (CorrectNumber(number))
{
    Console.WriteLine("Некорректный ввод. Просьба ввести цифру обозначающую день недели.");
}
else if (DayWeek(number))
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Нет, это не выходной день.");
}

bool CorrectNumber (int num)
{
    return num < 1 || num >= 8;
}
bool DayWeek (int n)
{
    return n > 5; 
}


