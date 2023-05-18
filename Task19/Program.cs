// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

string isPalindrom = IsPalindrom (number) ? "Да." : "Нет.";
Console.WriteLine (number < 10000 && number > 100000 
                        ? "Некорректный ввод, просьба ввести пятизначное число"
                        : isPalindrom);

bool IsPalindrom (int num)
{
    int firstDigit = num / 10000;
    int secondDigit = (num / 1000) % 10;
    int fourthDigit = (num / 10) % 10;
    int fifthDigit = num % 10;
    return firstDigit == fifthDigit && secondDigit == fourthDigit;
    
}


