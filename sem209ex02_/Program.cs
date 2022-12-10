//Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N

System.Console.WriteLine(PrintNumbers(100, 1000));
string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + " " + PrintNumbers(++start, end));
}
