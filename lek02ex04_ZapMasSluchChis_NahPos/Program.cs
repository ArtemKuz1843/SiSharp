//Генератор псевдо-случайных чисел и использование методов

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // в случае не нахождения значения выдавался индекс 0 - первого элемента, а это ошибка? принято -1 - не найдено
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index ++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[9] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444); //например будем искать 4. И заведомо отс. эл 444
Console.Write(pos);