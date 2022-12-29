// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arrayTab = new int[6, 6]
{
{1, 1, 1, 1, 1, 1},
{1, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 1},
{1, 0, 0, 0, 0, 1},
{1, 1, 1, 1, 1, 1}
};

void PrintArray2M(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray2M(arrayTab);
Console.WriteLine();

void FillHelix(int lines, int columns)
{
    if (arrayTab[lines, columns] == 0 && lines < arrayTab.GetLength(0) && columns < arrayTab.GetLength(1))
    {
        arrayTab[lines, columns] += 1;
        FillHelix(lines, columns + 1); arrayTab[lines, columns] += 1;
        FillHelix(lines + 1, columns);
        FillHelix(lines, columns - 1);
        FillHelix(lines - 1, columns);
        
    }
}

FillHelix(1, 1);
PrintArray2M(arrayTab);