// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// var array = FillArray(5);
// Print(array);
// Console.WriteLine();
// int[] newArr = MultiplyPair(array);
// Print(newArr);

// int[] MultiplyPair(int[] array)
// {
//     int newLength = 0;
//     if(array.Length % 2 == 0)
//     {
//         newLength = array.Length / 2;
//     }
//     else
//     {
//         newLength = array.Length / 2 + 1;
//     }
//     int[] result = new int[newLength];

//     for(int i = 0; i < newLength; i++)
//     {
//         if(i == array.Length - 1 - i)
//         {
//             result[i] = array[i];
//         }
//         else
//         {
//             result[i] = array[i] * array[array.Length - 1 - i];
//         }    
//     }
//     return result;
// }


int[] MultiplyPair(int[] array)
{
    int newLength = 0;
    if(array.Length % 2 == 0)
    {
        newLength = array.Length / 2;
    }
    else
    {
        newLength = array.Length / 2 + 1;
    }
    int[] result = new int[newLength];

    for(int i = 0; i < newLength; i++)
    {    
        result[i] = array[i] * array[array.Length - 1 - i];     
    }

    if(array.Length % 2 != 0)
    {
        result[newLength - 1] = array[array.Length / 2];
    }
    return result;
}
