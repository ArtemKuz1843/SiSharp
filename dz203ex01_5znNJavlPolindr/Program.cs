// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введитя пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    int num1 = (num / 10000) % 10;
    int num2 = (num / 1000) % 10;
    int num4 = (num / 10) % 10;
    int num5 = num % 10;
    if (num1 == num5 || num2 == num4)
    {
        Console.WriteLine("Является палиндромом");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }
}

else if (num >= 100000 || num < 10000)
{
    Console.WriteLine("Введённое число не пятизначное");
}