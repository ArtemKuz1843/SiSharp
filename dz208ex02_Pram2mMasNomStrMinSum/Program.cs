// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arrayTab = new int[5, 5];

Console.WriteLine("Сформирован прямоугольный двумерный массив:");

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
Console.WriteLine("Суммы строк:");

int[] ArrSumStr(int[,] array)
{
    int[] arrayStr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int SumStr = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumStr = SumStr + array[i, j];
        }
        arrayStr[i] = SumStr;
    }
    return arrayStr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
}

PrintArray(ArrSumStr(arrayTab));

Console.WriteLine();

void PrintMinStr(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[max] > arr[i]) max = i;
    }
    Console.WriteLine($"Сумма элементов строки № {max + 1} наименьшая");
}

PrintMinStr(ArrSumStr(arrayTab));