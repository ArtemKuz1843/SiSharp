﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число");
var num = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num} -> ");

for (int i = 1; i <= num; i++)
{
        if (i >= 2) // убираем запятую в конце "таблицы"
    {
        Console.Write(", ");
    }
    Console.Write(Math.Pow(i, 3)); // убираем запятую в конце "таблицы", важно, что последнее число именно после запятой, а не до, и цикл не повторяется.
}