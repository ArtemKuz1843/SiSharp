// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int CountDigits(int num)
// {
//     if (num != 0)
//     {
//         if (num < 0) num = -num;
//         int count = default;
//         while (num > 0)
//         {
//             num = num / 10;
//             count++;
//         }
//         return count;
//     }
//     return 1;
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = CountDigits(number);
// Console.WriteLine(result);

//Владимир Новиков, решение с циклом "for": Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int NumDig(int n1)
{
int i; //когда так объявляем i, тоже равно 0
for (i = 0; n1 > 0; i++)
{
    n1 = n1 / 10;
}
return i;
}
int result = NumDig(n);
Console.Write(result); // и так тоже выводит