// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру деня недели от 1 до 7 ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 8 && day > 1)
{
if (day == 1) Console.WriteLine("Не является выходным");
if (day == 2) Console.WriteLine("Не является выходным");
if (day == 3) Console.WriteLine("Не является выходным");
if (day == 4) Console.WriteLine("Не является выходным");
if (day == 5) Console.WriteLine("Не является выходным");
if (day == 6) Console.WriteLine("Является выходным днём");
if (day == 7) Console.WriteLine("Является выходным днём");
}
else Console.Write("Данного дня недели не существует");