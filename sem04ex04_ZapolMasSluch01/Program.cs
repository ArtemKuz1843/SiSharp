// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] arr = {5,5,5,5,5,5,5,5};
// //int[] arr = new int[8];

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// PrintArray(arr);

//-----------------

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// // Console.Clear();

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random(); //вывод ген сл ч из цикла для предотвр только 0 или только 1 или...
    for (int i = 0; i < count; i++)
    {
        // array[i] = new Random().Next(0, 2);
        array[i] = rnd.Next(0, 2); //использование новой переменной и типа Рандом
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        // как вариант по скобке  if (i == 0) Console.Write("[");
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

FillArray(arr);
PrintArray(arr);