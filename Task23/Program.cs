// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int numberN = Convert.ToInt32(Console.ReadLine());
SquareNumber(numberN);
void SquareNumber(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} {count * count,5} {count * count * count,8}");
        count++;
    } 
}