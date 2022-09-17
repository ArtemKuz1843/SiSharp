// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Программа примет число и вычислит значения кубов чисел от 1 до вашего числа.");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

void KubChisl(int n)
{
    int kub = 1;
    for (int i = 1; i < n+1; i++)
    {
        kub = i*i*i;
        if (i >= 2)
        {
            Console.Write(", ");
        }
        Console.Write($"{kub}");
    }
}
KubChisl(num);