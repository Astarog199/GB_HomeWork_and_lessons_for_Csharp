/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
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

// решение
void Calc(int[] array)
{
    int quantity = 0;

    for (int position = 0; position < array.Length; position++)
    {

        if (array[position] >= 10 && array[position] <= 99)
        {
            quantity++;
        }
    }
    Console.Write($"-> {quantity} ");
}


int[] array = FillArray(0, 123, 123);
PrintArray(array);
Calc(array);