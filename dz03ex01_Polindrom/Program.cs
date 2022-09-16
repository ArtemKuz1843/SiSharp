// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Программа проверит является ли пятизначное число полиндромом");
Console.WriteLine ("Введите пятизначное число:");
int num5 = Convert.ToInt32(Console.ReadLine());

//double x = 2.5;

double x = num5 / 10;
//double num01 = Math.Round (x , 2, MidpointRounding.ToZero);


Console.WriteLine ($"Остаток от деления на = {x}");

// string Polindrom(int num)
// {
//     int num01 = (num/10000) % 10;
//     int num02 = (num/1000) % 10;
//     int num03 = (num/100) % 10;
//     int num04 = (num/10) % 10;
//     int num05 = (num/10000) % 10;
// }