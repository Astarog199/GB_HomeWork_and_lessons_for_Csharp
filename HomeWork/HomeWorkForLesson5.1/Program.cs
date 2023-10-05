/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] FillArray(int min, int max, int size)

{
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(min, max + 1);
    }
    return array;
}

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


void Calc(int[] array)
{
    int res = 0;
    for (int position = 0; position < array.Length; position++)
    {
        if ((array[position] % 2) == 0)
        {
            res++;
        }
    }
    Console.WriteLine($"Number of even numbers in the array -> {res}");
}

int[] array = FillArray(99, 1000, 10);
PrintArray(array);
Calc(array);