/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        if ((position % 2) == 1)
        {
            res += array[position];
        }
    }
    Console.WriteLine($"Sum of elements -> {res}");
}

int[] array = FillArray(0, 9, 5);
PrintArray(array);
Calc(array);