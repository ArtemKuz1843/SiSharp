// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 (ошибка в условиях? 4)

Console.WriteLine("Сколько чисел вы введёте: ");
int lon = Convert.ToInt32(Console.ReadLine());
if (lon <= 0)
{
    Console.WriteLine("Введите число больше нуля");
}
int[] Arr = new int[lon];

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

Console.WriteLine($"Созданн массив для заполнения: ");
PrintArray(Arr);

Console.WriteLine();

int[] InsertArray(int[] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите число {i+1}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.WriteLine();

PrintArray(InsertArray(Arr));
Console.Write(" - ваш массив");

int PositivN(int[] array)
{
    int n = array.Length;
    int positiv = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0)
        {
            positiv = positiv + 1;
        }
    }
    if (positiv == 0)
    {
    positiv = -1;
    }
    return positiv;
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Введено чисел больше нуля: {PositivN(Arr)}");
