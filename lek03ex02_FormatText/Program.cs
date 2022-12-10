// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// string s = “qwerty”
// 012345
// В частности, если требуется обратиться к конкретному символу строки, мы можем это делать,
// начиная отсчитывать позицию символов с 0. То есть «q» — это 0, «w» — 1, «e» — 2 и так далее.
// Чтобы получить конкретный символ, мы можем через квадратные скобки обратиться, указать
// идентификатор строки. Например:
// s[3] // r  
//!!!получается строка  - это массив!!!

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue) //char cимвольный тип
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
      if(text[i] == oldValue) result = result + $"{newValue}";  
      else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);