// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
var num = Convert.ToInt32(Console.ReadLine());

if (num > 999 && num > 99)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}

else
{
    Console.WriteLine("В числе нет третьей цифры");
}