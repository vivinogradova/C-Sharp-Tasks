// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Посьба ввести размер создаваемого трехмерного массива: ");
Console.WriteLine("Количество строк: ");
int rows3dMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int columns3dMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И глубину массива: ");
int depth3dMatrix = Convert.ToInt32(Console.ReadLine());

if (rows3dMatrix*columns3dMatrix*depth3dMatrix>99)
{
    Console.WriteLine("Невозможно создать массив неповторяющихся двузначных чисел.");
    Console.WriteLine("Просьба ввести меньшие размеры трехмерного массива.");
}
else
{
int[,,] createMatrix3d = CreateMatrix3dRndInt(rows3dMatrix, columns3dMatrix, depth3dMatrix, 10);
PrintMatrix3d(createMatrix3d);
Console.WriteLine();
}

int[,,] CreateMatrix3dRndInt(int rows, int columns, int depth, int count)
{
    int[,,] matrix3d = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                matrix3d[i, j, k] = count;
                count++;
            }

        }
    }
    return matrix3d;
}

void PrintMatrix3d(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
}

