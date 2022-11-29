// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

int[] СomplArray(int length)
{
    int[] Сompl = new int[length];
    for(int i =0; i < Сompl.Length; i++)
    {
        Сompl[i] = new Random().Next(0, 101);
    }
    return Сompl;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

PrintArray(СomplArray(8));