/*

Задача 39: Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте, а первый - на
последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

*/

int[] FillArray(int min, int max, int size)
{
    int[] array = new int[size]; // инициализация массива
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(min, max + 1); // ЗАполнение массива случайными числами
    }
    return array;
}


int[] reverseArray(int[] array)
{
    int size = array.Length;

    for (int position = 0; position < size / 2; position++)
    {
        int temp = array[position];
        array[position] = array[size - 1 - position];
        array[size - 1 - position] = temp;
    }
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    Console.Write($"Array -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]} ");
    }
    Console.WriteLine("]");
}



int[] array = FillArray(0, 9, 5);
Console.WriteLine("Массив");
PrintArray(array);


Console.WriteLine("Инверсия array");
PrintArray(reverseArray(array));
