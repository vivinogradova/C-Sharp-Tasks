// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3


Console.WriteLine("Введите первое целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB)
{
   Console.WriteLine("Некорректный ввод. Просьба ввести два разных числа."); 
}
else if (numberA > numberB)
{
   Console.WriteLine($"Число {numberA} большее, а число {numberB} меньшее.");

}
else
{
    Console.WriteLine($"Число {numberB} большее, а число {numberA} меньшее.");
}