// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// 88 -> цифры одинаковые

int number = new Random().Next(10, 100);  //генератор случайных чисел, берём до 100 т.к. значение 100 не входит
// int firstDidgit = number / 10; //7
// int secondDidgit = number % 10; //8

// if (firstDidgit > secondDidgit) Console.WriteLine ($"Наибольшая цифра числа{number} -> {firstDidgit}");
// else Console.WriteLine ($"Наибольшая цифра числа {number} -> {secondDidgit}");

//если числа окажутся одинаковыми, не проверяет на равенство, выдаст одно из


// if (firstDidgit == secondDidgit) Console.WriteLine($"Цифры равны");

// else
// {
//     int max = firstDidgit > secondDidgit ? firstDidgit : secondDidgit;
//     // если выполняетя условие ,(> ?) тогда присваиваем firstDidgit (: )иначе secondDidgit

//     Console.WriteLine($"Наибольшая цифра числа {number} -> {max}");
// }

//int max1 = Math.Max(8, 8); //Встроенный метод, ниже мы описали аналог

int MaxDidgit(int num)
{
    int firstDidgit = num / 10;
    int secondDidgit = num % 10;
    // int maxDid = firstDidgit > secondDidgit ? firstDidgit : secondDidgit;
    // return maxDid;
    if (firstDidgit == secondDidgit) return 0;
    return firstDidgit > secondDidgit ? firstDidgit : secondDidgit;
}

int maxDidgit = MaxDidgit(number);
string  result = maxDidgit > 0 ? maxDidgit.ToString() : "Цифры равны"; //сузить диапазон для проверки
Console.WriteLine($"Наибольшая цифра числа {number} -> {result}");