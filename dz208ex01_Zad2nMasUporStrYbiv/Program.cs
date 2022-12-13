// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arrayTab = new int[5, 5];

Console.WriteLine("Сформирован двумерный массив:");

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

FilPrintArray(arrayTab);

Console.WriteLine();
Console.WriteLine("Элементы строк массива отсортируются по убыванию:");

void SortPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, max] < array[i, k]) max = k;
            }
            int buf = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = buf;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

SortPrint(arrayTab);