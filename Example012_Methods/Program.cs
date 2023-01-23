/*Первая группа методов -ничего не принимают и не возвращают*/
void Method1()
{
    Console.WriteLine("например ФИО автора");
}
//Method1(); //команда для вызова метода(скобки обязательны)
/*Вторая группа методов - могут принимать, но не возвращают*/
//ключевое слово/идентификатор/аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4); //4 - кол-во раз для выведения слова текст
//Method21(count: 4, msg: "новый текст"); //можно указывать аргументы не по порядку

/*Третья группа методов - ничего не принимают, но могут что-то возвращать. Если метод что-то возвращает, то вначале нужно обязательно указать тип данных*/
int Method3()  //в скобках ничего не указывается, т.к. он не принимает аргументы
{
    return DateTime.Now.Year;  //в этом методе обязательно импользование оператора return
}
int year = Method3();
//Console.WriteLine(year);

/*Четвертая группа методов - что-то принимают и что-то возвращают*/

/*string Method4(int count, string c) //string вначале говорит о том, что будем возвращать строку. Строку С будем компоновать count раз
{
    int i = 0;
    string result = String.Empty;//string result = ""; резалт изначально пустая строка
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "asdfg");
Console.WriteLine(res);*/

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "asdfg");
//Console.WriteLine(res);

/*Таблица умножения*/
/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}*/

/*//=====Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "с" заменить маленькими "С".

//Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwert"
//            01234
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

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
newText = Replace(newText, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с','С');
Console.WriteLine(newText);*/


//сортировка
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };  //задаем массив

void PrintArray(int[] array)  //вывод массива на экран(Метод PrintArray, в качестве аргумента массив)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); //будет указывать элементы массива через пробел
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)  //добавляем метод сортировки
{
    for (int i = 0; i < array.Length - 1; i++)  //Обращение к длинне массива через array.Length
    {
        int minPosition = i;  //задаем начальную позицию
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;  //заменить минимальную позицию если меньше текущей и сохранить
        }

        int temporary = array[i];           //рабочая позиция
        array[i] = array[minPosition];      //меняем местами начальную и рабочую если выполняются условия
        array[minPosition] = temporary;     //в минимальную позицию кладем временный элемент 
    }

}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

// ДЗ в обратную сторону(от большего к меньшему)