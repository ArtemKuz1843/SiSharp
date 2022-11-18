// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа примет число и покажет все чётные числа от 1 до этого числа.");
Console.WriteLine("Введите число: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
int ost = num2 % 2;

Console.WriteLine();

if (num1 > num2)
{
    while (num1 >= num2)
    {
        if (ost == 0)
        {
            Console.WriteLine(num2);
        }
        num2 = num2 + 1;
        ost = num2 % 2;
    }
}
else if (num2 > num1)
{
    while (num2 >= num1)
    {
        if (ost == 0)
        {
            Console.WriteLine(num2);
        }
        num2 = num2 - 1;
        ost = num2 % 2;
    }
}

if (num1 == 1) Console.WriteLine("Согласно условиям отсутствуют значения для вывода");