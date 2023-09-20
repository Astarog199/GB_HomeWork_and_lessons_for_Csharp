/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
*/

int i = new Random().Next(10, 9999);
// int i = -72;
int num = i;
if (num < 0) num = num * (-1);



// char[] arr = num.ToString().ToCharArray();
// if (arr.Length == 2)
// {
//     Console.WriteLine("there is no third digit");
// }
// else
// {
//     Console.WriteLine($"last character of the number {i}: {arr[2]}");
// }



int Check(int num)
{
    int step = 1;
    while (num > 10)
    {
        num = num / 10;
        step++;
    }
    return step;
}



void myFunc(int i, int num, int length)
{
    while (length > 3)
    {
        num = num / 10;
        length--;
    }

    if (length == 3)
    {
        int res = num - ((num / 10) * 10);
        Console.Write($"last character of the number {i}: {res}");
    }
    else
    {
        Console.WriteLine("there is no third digit");
    }
}

int length = Check(num);
myFunc(i, num, length);
