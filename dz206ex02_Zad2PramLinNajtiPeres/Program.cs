// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Две прямые заданны уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.WriteLine();

Console.Write("Задайте  параметр b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте  параметр k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте  параметр b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте  параметр k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

void CrossingPoint(int mumb1, int mumk1, int mumb2, int mumk2)
{
    if (mumk1 != mumk2)
    {
    double x01 = mumb2 - mumb1;
    double x02 = mumk1 - mumk2;
    double x = x01 / x02; 
    //double x = (mumb2 - mumb1) / (mumk1 - mumk2);
    double y01 = mumk1 * x;
    double y = y01 + mumb1;
    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}

Console.WriteLine();
CrossingPoint(b1, k1, b2, k2);