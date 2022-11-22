// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int num1 = 125;
Console.WriteLine("Sum: " + GetSum(num1));
Console.WriteLine($"In program{num1}");

int GetSum(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
