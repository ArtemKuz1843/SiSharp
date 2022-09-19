// 12. Напишите прорграмму, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно 1,
// то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> не кратно

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

bool Multiplicity(int a1, int b1)  //наконец-то применение типа данных BOOL
{
    return a1 % b1 == 0;
}

bool result = Multiplicity(num1, num2);
if (result) Console.WriteLine($"Число {num1} кратно {num2}"); //if (result) = true
else Console.WriteLine($"Число {num1} не кратно {num2}, остаток от деления {num1 % num2}");