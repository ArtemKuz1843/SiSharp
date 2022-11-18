// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Программа вычислит является ли число чётным.");
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int ost = num1 % 2;
if (ost == 0)
{
    Console.WriteLine($"{num1} -чётное число");
}
else
{
    Console.WriteLine($"{num1} -не является чётным");
}