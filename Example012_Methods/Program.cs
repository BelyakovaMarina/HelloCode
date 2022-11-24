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


string text = " - Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласия прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?"
            






