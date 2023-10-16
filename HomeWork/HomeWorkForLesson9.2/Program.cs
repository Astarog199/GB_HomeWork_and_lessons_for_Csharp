/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/


Console.Write($"Enter the number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter the number n: ");
int n = Convert.ToInt32(Console.ReadLine());



int ShoWValues(int m, int n)
{
    if (/* Math.Min(m, n) < Math.Max(m, n) */ m <= n)
    {

        Console.WriteLine($"n: {n} ");
        return ShoWValues(m, n - 1) + n;
    }
    else
    {
        return 0;
    }

}

int result = ShoWValues(m, n);

Console.Write(result);