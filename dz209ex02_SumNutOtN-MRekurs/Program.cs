// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int numberM, int numberN)
{
    int sum = numberM;
    if (numberM == numberN)
    {
        return sum;
    }
    return (sum + SumNumbers(numberM + 1, numberN));
}