// 17. Напишите программу, которая примет на вход координаты точки Y и X , притом Х и У не равно 0, и выдаст номер четверти плоскости, в которой находится эта точка. 

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвёртая четверть";
    return "Введены некорректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);