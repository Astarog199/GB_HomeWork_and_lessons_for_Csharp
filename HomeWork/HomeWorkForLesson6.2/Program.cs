/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


// Создание массива и заполнение его

using System.Runtime.Intrinsics.X86;

int[] FillArray(int b1, int k1, int b2, int k2)

{
    int[] array = new int[4];

    array[0] = b1;
    array[1] = k1;
    array[2] = b2;
    array[3] = k2;

    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"b1 = {array[0]}");
    Console.WriteLine($"k1 = {array[1]}");
    Console.WriteLine($"b2 = {array[2]}");
    Console.WriteLine($"b3 = {array[3]}");
}


void Calc(int[] array)
{
    double x1 = array[2] - array[0];
    double x2 = array[1] - array[3];
    double x = x1 / x2;

    double res = array[1] * x + array[0];
    double res2 = array[3] * x + array[2];

    Console.WriteLine($"Point of intersection of two lines-> {res}, {res2}");
}


Console.WriteLine("Set values for b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Set values for k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Set values for b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Set values for k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(b1, k1, b2, k2);
PrintArray(array);
Calc(array);