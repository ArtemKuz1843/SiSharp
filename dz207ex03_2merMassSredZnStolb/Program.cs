// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arrayTab = new int[5, 5];

void FilPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 6);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FilPrintArray(arrayTab);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");

void AverArifm(int[,] array)
{
    int[] SumColumns = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        SumColumns[j] = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        
        {
            SumColumns[j] += array[i, j];
        }
        float aveAri = SumColumns[j]/array.GetLength(1);
        Console.WriteLine(aveAri);
    }
}

AverArifm(arrayTab);