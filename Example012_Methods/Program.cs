//Вид1

/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();
*/

//Вид2 - вариант1

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); //или Method2(msg: "Текст сообщения");
*/

//Вид2 - вариант2

/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
//или Method21(msg: "Текст", count: 4);
//или Method21(count: 4, msg: "Текст");
*/

//Вид3

/*
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);
*/

//Вид4

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
return result;
}
string res = Method4(10, "asfd");
Console.WriteLine(res);
*/

//циклы с for по Вид4

/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
*/

//вывод таблицы умножения на экран

/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//дан текст. нужно все пробелы заменить черточками, маленькие буквы "к" заменить бальшими "К", 
//а большие "С" заменить маленькими "с".

/*
string text = " - Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласия прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю? ";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
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

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/

//Задача. Упорядочить массив.
//например 6 8 3 2 1 4 5 7 -> 1 2 3 4 5 6 7 8
//1.найти позицию минимального элемента в неотсортированной части массива
//2.произвести обмен этого значения со значением первой неотсортированной позиции
//3.повторять пока есть неотсортированные элементы.


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

