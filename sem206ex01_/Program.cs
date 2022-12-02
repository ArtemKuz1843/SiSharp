// (int,int) GetTwoNums(params int[] array) .//для ДЗ
// {
//     int max = array[0];
//     int min = array[0];
//     for(int i = 1; i<array.Length;i++)
//     {
//         if(array[i]>max)
//         {
//             max = array[i];
//         }
//         if(array[i]<min)
//         {
//             min = array[i];
//         }
//     }
//     return(min,max);
// }
// int[] array = {1,3,4,5,6,};
// var result = GetTwoNums(1,2,3,4,5,6);
// System.Console.WriteLine(result.Item1);


// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

int[] array = {1,2,3,4,5}; 

Print(ReverseArray(array));

int[] ReverseArray(int[] array)
{
    int length = array.Length;
    int[] result = new int[length];
    for(int i = length-1; i >= 0; i--)
    {
        result[length-1-i] = array[i];
    }

    return result;
}
