// Console.WriteLine("Программа примет число и покажет все чётные числа от 1 до этого числа.");
// Console.WriteLine("Введите число: ");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = 1;
// //int ost = num2 % 2;
// if (num1 > num2)
// {
//     while (num1 >= num2)
//     {
//         num2 = num2 + 1;
//         ost = num2*num2;
//         Console.WriteLine(ost);
//     }
// }
// // else if (num2 >= num1)
// // {
// //     while (num2 > num1)
// //     {
// //         if (ost == 0)
//         {
//             Console.WriteLine($"Чётное число {num2}");
//         }
//         num2 = num2 - 1;
//         ost = num2 % 2;
//     }
// }
// if (num1 == 0) Console.WriteLine("Согласно условиям отсутствуют значения для вывода");
// if (num1 == 2) Console.WriteLine("Согласно условиям отсутствуют значения для вывода");
// if (num1 == 1) Console.WriteLine("Согласно условиям отсутствуют значения для вывода");


// Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int cnt = 0;
// while (cnt != n)
// {
//     cnt++;
//     Console.WriteLine($"{cnt} {cnt*cnt}");
// }


Console.Clear();
Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Square(int digit1, int count1)
{
    while(count1 <= digit1)
    {
        Console.WriteLine($"|{count1}-{count1 * count1}|");
        count1 ++;
    }
}
Square(digit, count);
