/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void DayOfWeek(int arr)
{
    if (arr > 0 && arr < 7)
    {
        if (arr < 6)
        {
            Console.WriteLine("weekday");
        }
        else
        {
            Console.WriteLine("day off");
        }
    }
    else
    {
        Console.WriteLine("false");
    }
}

Console.WriteLine("Enter the number:");
int arr = Convert.ToInt32(Console.ReadLine());

DayOfWeek(arr);