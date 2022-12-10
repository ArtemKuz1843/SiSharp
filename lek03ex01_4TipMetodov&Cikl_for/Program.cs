// 1 Группа методов. Ничего не принимают, ничего не возвращают
// void Method1()
// {
//     Console.WriteLine("Автор КАН");
// }
// // как вызываются подобные методы
// Method1(); //идентификатор и круглые скобки




// // 2 Группа методов. Что-то принимают, ничего не возвращают Void
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения");

// //бывают именнованные аргументы, когда мы хотим указать нужному аргументу нужное значение, когда их более 1
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21("Текст", 4);
// // Method21(msg: "Текст",count: 4); //можем явно указывать какому аргументу какое значение мы хотим присвоить
// Method21(count: 4, msg: "Текст"); //не обязательно писать по порядку



// 3 Группа методов. Ничего не принимают, что-то возвращают
// int Method3()
// {
//     return DateTime.Now.Year; //достать дату
// }

// int year = Method3();
// Console.WriteLine(year);


// 4 Группа методов. Что-то принимают, что-то возвращают

// string Method4(int count, string text) // char c
// {
//     int i = 0;
//     string result = String.Empty; // String.Empty значение пустой строки для понимания кода программистами 
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z"); //а можно взять символ z, который для нас сейчас является строкой! Сергей Камянецкий. Лучшее, в Фоннд золотых цитат!
// Console.WriteLine(res); 

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

//string res = Method4(10, "z");  
//Console.WriteLine(res);

//таблица умножения
for(int i = 2; i <10; i++)
{
    for (int j = 2; j <10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();//переход н новую строку
}
// офигеть, работает без всяких объявлений переменных