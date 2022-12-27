// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string NunuralNumbers(int number, int one)
{
    if (number == one)
    {
        return number.ToString();
    }
    return (number + " " + NunuralNumbers(number - 1, one));
}

System.Console.WriteLine(NunuralNumbers(8, 1));