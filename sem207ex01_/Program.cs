// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2

Console.WriteLine("Введитен количество строк и столбцов");

int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

int[,] arrayTab = new int [X, Y];

for (int i =0; i < arrayTab.GetLength(0); i++)
{
    for (int j=0; j < arrayTab.GetLength (1); j++)
    {
        arrayTab[i,j] = new Random().Next(0, 10);
        Console.Write($"{arrayTab[i,j]} ");
    }
    Console.WriteLine();
}


// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] array = new int[m, n];

// FillArray(array);
// Print(array);
// int[,] FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(-10, 10);
//         }
//     }
//     return arr;
// }
// void Print(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }
