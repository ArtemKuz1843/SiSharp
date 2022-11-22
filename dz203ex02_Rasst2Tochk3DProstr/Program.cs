// Задача 21.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Х1 ");
var X1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату У1 ");
var Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z1 ");
var Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2 ");
var X2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату У2 ");
var Y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z1 ");
var Z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2) + Math.Pow((Z1-Z2),2));

Console.Write(result);