// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] arrayTab1 = new int[2, 2]{{2, 4}, {3, 2}};
// int columnsTab1 = arrayTab1.GetLength(1);
// int[,] arrayTab2 = new int[2, 2] {{3, 4}, {3, 3}};

int[,] arrayTab1 = new int[2, 2];
int columnsTab1 = arrayTab1.GetLength(1);
int[,] arrayTab2 = new int[columnsTab1, 2];

void FilPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Первая матрица:");
FilPrintArray(arrayTab1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
FilPrintArray(arrayTab2);

Console.WriteLine();

void MultiplyMatrix(int[,] array1, int[,] array2)
{
    int lines = array1.GetLength(0);
    int columns = array2.GetLength(1);
    int[,] arraySumMatr = new int[lines, columns];
    for (int k = 0; k < array1.GetLength(0); k++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            int sum = 0;
            for (int c = 0; c < array2.GetLength(0); c++)
            {
                sum = sum + array1[k, c] * array2[c, n];
            }
            arraySumMatr[k, n] = sum;
            Console.Write($"{arraySumMatr[k, n]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Результат перемноженийя матриц:");
MultiplyMatrix(arrayTab1, arrayTab2);