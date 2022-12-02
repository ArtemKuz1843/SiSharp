// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

PrintFibanachiNum(10);

void PrintFibanachiNum(int count)
{
    
    int currentNum = 0;
    int currentCount = 2;
    int firstNum = 0;
    int secondNum = 1;
    Console.Write("0, 1, ");
    while(currentCount != count)
    {
        currentNum = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = currentNum;
        Console.Write($"{currentNum}, ");
        currentCount++;
    }
}
