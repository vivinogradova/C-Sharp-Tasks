// ДОМАШНЕЕ ЗАДАНИЕ:
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Ведите какое количество раз Вы хотите вводить число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] newArrayIncomingNumbers = IncomingNumbers(number);
PrintArray(newArrayIncomingNumbers);
int countNumMoreZero = CountNumMoreZero(newArrayIncomingNumbers);
Console.Write($" -> {countNumMoreZero}");

int[] IncomingNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Ведите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int CountNumMoreZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


// Вариант без исполььзования массива в один метод:
//
// Console.WriteLine("Ведите какое количество раз Вы хотите вводить число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int countNumMoreZero = CountNumMoreZero(number);
// Console.WriteLine($"Количество чисел больше 0 которые Вы ввели = {countNumMoreZero}.");
// int CountNumMoreZero (int num)
// {
//     int count = 0;
//     for (int i = 0; i < num; i++)
//     {
//         Console.WriteLine($"Ведите {i+1} число: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         if(number > 0) count++;
//     }
//     return count;
// }