// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int MetSum(int digit)
{
    // int sum = 0;
    // int ost = 0;
    // while(digit >= 1)
    // {
    //     ost = digit % 10;
    //     sum = sum + ost;
    //     digit = digit / 10;
    // }
    // return sum;

    int sum = 0;
    int ost = 0;
    while (digit > 0)
    {
        //ost = digit % 10;
        sum += digit % 10;
        digit /= 10;
    }
    return sum;
}

Console.WriteLine();
Console.WriteLine(MetSum(num));