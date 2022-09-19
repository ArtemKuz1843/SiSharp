// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int MaxDidgit(int num)
{
    int firstDidgit = num / 100 * 10;
    int secondDidgit = num % 10;
    return firstDidgit+secondDidgit;
}
int result = MaxDidgit(number);
Console.WriteLine($"{number} -> {result}");