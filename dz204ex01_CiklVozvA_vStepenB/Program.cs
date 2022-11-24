// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

int Exp(int num1, int num2)
{
    int expon = num1;
    for(int i=2; i <= num2; i++)
    {
        expon = expon * num1;
    }
        return expon;
}

Console.WriteLine();
Console.WriteLine(Exp(numA, numB));