﻿void Method1()
{
    Console.WriteLine(" autor ..");
}
//Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("text ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("text ", 4);

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
string Method4(int count, string text)
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++ )
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, " asdf");
Console.WriteLine(res);