// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.Write("Введите координату Х1 ");
var X1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату У1 ");
var Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2 ");
var X2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату У2 ");
var Y2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2));

Console.Write(result);