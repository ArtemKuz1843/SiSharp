Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SunNumbers(int num) //цикл for
{
    int sum = default;  //значение по умолчанию '0'

    for (int i = 1; i <= num; i++) //цикл for при наборе квадратом выберется шаблон
    {
        sum += i; //sum = sum + i;
    }
    return sum;
}
int sunNumbers = SunNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sunNumbers}");



// // Задача 24: Напишите программу, которая
// // принимает на вход число (А) и выдаёт сумму чисел
// // от 1 до А.
// // 7 -> 28
// // 4 -> 10
// // 8 -> 36

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     int sum = default;

//     for (int i = 1; i <= num; i++)
//     {
//         //sum = sum + i;
//         sum += i;
//     }
//     return sum;
// }

// int sumNumbers = SumNumbers(number);
// Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
// 89126 -> 5
