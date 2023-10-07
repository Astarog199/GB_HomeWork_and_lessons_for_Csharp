/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
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
    int size = 0;
    int firstPosition = 0;
    int lastPosition = array.Length - (1);

    if ((array.Length % 2) == 0)
        size = array.Length / 2;
    else
    {
        size = array.Length / 2 + 1;
    }


    int[] newArray = new int[size];


    for (int position = 0; position < array.Length / 2; position++)
    {
        newArray[position] = array[firstPosition] * array[lastPosition];
        firstPosition++;
        lastPosition--;
    }

    if ((array.Length % 2) == 1)
    {
        Console.WriteLine(array.Length - (array.Length / 2));
        newArray[size - 1] = array[array.Length / 2];
    }

    PrintArray(newArray);
}

int[] array = FillArray(0, 9, 11);
PrintArray(array);
Calc(array);