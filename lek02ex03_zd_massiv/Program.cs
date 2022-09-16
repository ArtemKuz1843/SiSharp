int[] array = { 1, 12, 31, 18, 15, 16, 17, 18 };

int n = array.Length; //Length - возвращает длину, ко-во элементов массива
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;           //остановит поиск, находит первый элемент, совпадение
    }
    index++;
}