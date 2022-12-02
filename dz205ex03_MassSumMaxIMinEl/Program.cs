// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];

void PrintArray(double[] arr)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
    // for(int i =0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]}, ");
    // }
}

PrintArray(array); // массив создан и заполнен нулями

Console.WriteLine();

double[] FillArray(double[] arr)
{
    double[] result = new double[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        result[i] = new Random().NextDouble(-10, 10);
    }
    return result;
}

var newArray = FillArray(array);

PrintArray(newArray); // массив, заполненный случайными числами, 0-10

// Console.WriteLine();

// int SumNoEvenPos(int[] arr)
// {
//     int sumNoEvenI = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sumNoEvenI += arr[i];
//         }
//     }
//     return sumNoEvenI;
// }

// Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях в массиве: {SumNoEvenPos(newArray)}"); // сумма элементов, стоящих на нечётных позициях