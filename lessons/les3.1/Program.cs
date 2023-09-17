// 1 мектод
// void Method1()
// {
//     Console.WriteLine("тест");
// }
// Method1();

// 2 метод
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("тест");

// 3 метод
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// 4 метод
string Method4(int count, string text)
{
    string result = String.Empty; // создаём пустую строку

    for (int i = 0; i < count; i++)
    {
        result = result + text + i;
    }
    return result;
}
string res = Method4(10, " тест ");
Console.WriteLine(res);