// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введитен количество строк и столбцов");

int lines = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arrayTab = new double[lines, columns];

void FilPrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 1, MidpointRounding.ToZero);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FilPrintArray(arrayTab);