// /Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

var X = Convert.ToInt32(Console.ReadLine());
var Y = Convert.ToInt32(Console.ReadLine());

if( X > 0 && Y > 0 )
{
    Console.WriteLine("1");
}
else if ( X < 0 && Y > 0 )
{
    Console.WriteLine("2");
}
else if ( X < 0 && Y < 0 )
{
    Console.WriteLine("3");
}
else if ( X > 0 && Y > 0 )
{
    Console.WriteLine("4");
}