// Задача 21  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа примет координаты 2 точек в 3D пространстве и вычислит расстояние между ними.");
Console.WriteLine("Введите координаты 1 точки");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты 2 точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
return d;
}

double dist = distance3D(x1, y1, z1, x2, y2, z2);
dist = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine(dist);

//Console.WriteLine(Math.Round(distance3D(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero)); //сокращённый вариант, код в одну строчку не значит хороший
