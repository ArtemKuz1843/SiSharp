﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//double num01 = Math.Round (x , 2, MidpointRounding.ToZero);

Console.WriteLine ("Программа проверит является ли пятизначное число полиндромом");
Console.WriteLine ("Введите пятизначное число:");
int num5 = Convert.ToInt32(Console.ReadLine());

// int num01 = (num5/10000) % 10;
// int num02 = (num5/1000) % 10;
// int num03 = (num5/100) % 10;
// int num04 = (num5/10) % 10;
// int num05 = (num5/10000) % 10;
//Console.WriteLine ($"Остаток от деления на = {num01}, {num02}, {num03}, {num04}, {num05}");


string Polindrom(int num)
{
    int num01 = (num/10000) % 10;
    int num02 = (num/1000) % 10;
    int num04 = (num/10) % 10;
    int num05 = (num/10000) % 10;
    string poli = "полиндромом";
    if (num01 == num05 && num02 == num04)
    {
        poli = "Число является полиндромом";
    }
    else
    {
        poli = "Число не является полиндромом";
    }
    return poli;
}

Polindrom(num5);
string itog = Polindrom(num5);
Console.WriteLine (itog);