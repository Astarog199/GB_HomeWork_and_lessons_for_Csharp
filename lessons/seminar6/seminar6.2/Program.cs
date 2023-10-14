/*
Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон

*/

// Создание массива и заполнение его

int[] FillArray(int min, int max, int size)

{
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(min, max + 1);
    }
    return array;
}

// Вывод массива
void PrintArray(int[] array)
{
    int size = array.Length;

    Console.Write($"Массив из {size} элементов -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]} ");
    }

    Console.WriteLine("]");
}

bool Calc(int[] array)
{

    bool AB = array[2] < array[1] + array[0];
    bool AC = array[1] < array[2] + array[0];
    bool BC = array[0] < array[2] + array[1];

    if (AB && AC && BC)
        return true;
    else
        return false;
}

int[] array = FillArray(0, 10, 3);
PrintArray(array);
Console.WriteLine(Calc(array));