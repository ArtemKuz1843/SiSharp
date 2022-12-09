// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет



int[,] arrayTab = new int[5, 10];

void FilPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FilPrintArray(arrayTab);

Console.WriteLine("Введите позицию желаемого элемента, номер строки и номер столбца):");
int lines = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
// задать вопрос как написать в данном случае код с примененреи типа данных bool

if (lines < 1 || lines > arrayTab.GetLength(0) || columns < 1 || columns > arrayTab.GetLength(1))
{
    Console.WriteLine("В массиве отсутствует подобная позиция");
} 
else
{
    Console.WriteLine($"Ваш элемент: {arrayTab[lines-1, columns-1]}");
}