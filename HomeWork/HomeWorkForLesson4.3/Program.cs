/*
Задача 29: Напишите программу, которая задаёт массив из произвольного числа элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col, int quantity)
{
    int count = col.Length;
    int position = 0;
    Console.Write($"Массив из {quantity} элементов -> [");
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
    Console.Write("]");
}

int quantity = new Random().Next(5, 11);
int[] array = new int[quantity];
FillArray(array);
PrintArray(array, quantity);