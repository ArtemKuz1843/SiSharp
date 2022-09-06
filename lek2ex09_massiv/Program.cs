int maxF (int arg1, int arg2, int arg3)  //описываем аргументы
{                                       //тело метода
    int result = arg1;                  //result - где будет храниться значение максимального
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                      //возвращение result
}

//определяем массив
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 211 ,31, 41, 15, 61, 17, 18, 19 }; //тип данных, имя, значение
//array[0] = 12; //нулевому элементу массива присвоить значение 12
//Console.WriteLine(array[4]); //получить значение по индексу

int max = maxF(maxF(array[0], array[1], array[2]),
               maxF(array[3], array[4], array[5]),
               maxF(array[6], array[7], array[8])
              );

// int max1 = maxF(a1, b1, c1);           //результатом работы функции max будет максимальное из 3 чисел
// int max2 = maxF(a2, b2, c2);   
// int max3 = maxF(a3, b3, c3); 
// int max = maxF(max1, max2, max3);      //Натравим нашу функцию на все тройки "игроков"

// int max = maxF(                           //внутри аргумента можно передать функцию
//                maxF(a1, b1, c1),
//                maxF(a2, b2, c2),
//                maxF(a3, b3, c3));         

Console.WriteLine(max);