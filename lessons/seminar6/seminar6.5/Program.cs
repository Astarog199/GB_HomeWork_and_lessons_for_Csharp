/*
Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
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

int[] mirrorArray(int[] array)
{
    int size = array.Length;
    int[] newArray = new int[size];
    int index = 0;
    for (int position = size - 1; position >= 0; position--)
    {
        newArray[index] = array[position];
        index++;
    }
    return newArray;
}


int[] array = FillArray(0, 9, 11);
PrintArray(array);

Console.WriteLine("Создание нового зеркального массива");
int[] newArray = mirrorArray(array);
PrintArray(newArray);