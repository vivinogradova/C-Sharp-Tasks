// 11. Напишите программу, которая 
// выводит случайное трёхзначное число и 
// удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); // 100, 999+1
Console.WriteLine ($"Случайное трёхзначное число -> {number}");
int newNumber = DeleteSecondDigit(number);
Console.WriteLine ($"Это же число без втрой цифры -> {newNumber}.");
int DeleteSecondDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = (firstDigit * 10) + thirdDigit;
    return result;
}