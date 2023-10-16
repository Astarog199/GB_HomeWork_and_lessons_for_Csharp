/*
Задайте значение N. напишите программу, 
котрая выдаёт все натуральные числа 
в промежутке от 1 до N
*/

void ShowNumber(int n)
{
    if (n > 1) ShowNumber(n - 1);
    Console.Write($"{n} ");
}

ShowNumber(5);