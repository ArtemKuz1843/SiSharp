// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
var den = Convert.ToInt32(Console.ReadLine());

if (den == 6 || den == 7)
{
    Console.WriteLine("Является выходным днём");
}
else if (den >= 1 && den <= 5)
{
    Console.WriteLine("Не является выходным днём");
}
else
{
    Console.WriteLine("Число не является днём недели");
}