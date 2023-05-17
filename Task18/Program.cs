// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
string numQuarter = Console.ReadLine();
string rangi = Rangi(numQuarter);
Console.WriteLine(rangi == null ? "Некорректный ввод." : rangi);
string Rangi(string num)
{
    if (num == "1" || num == "один") return "x > 0 && y > 0";
    if (num == "2" || num == "два") return "x < 0 && y > 0";
    if (num == "3" || num == "три") return "x < 0 && y < 0";
    if (num == "4" || num == "четыре") return "x > 0 && y < 0";
    return null;
}