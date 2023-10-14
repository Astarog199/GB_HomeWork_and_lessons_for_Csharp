/*
Нужно найти 2 максимальных элемента произвольного массива
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

void mirrorArray(int[] array)
{

    int arrayMax = 0;
    int arrayMax2 = 0;

    for (int position = 0; position < array.Length; position++)
    {
        if (arrayMax < array[position])
            arrayMax = array[position];
    }

    for (int position = 0; position < array.Length; position++)
    {
        if (arrayMax2 < array[position] && arrayMax != array[position])
            arrayMax2 = array[position];
    }
    Console.WriteLine($"Первое максимальное число: {arrayMax}");
    Console.WriteLine($"Второе максимальное число: {arrayMax2}");
}


int[] array = FillArray(0, 9, 5);
PrintArray(array);
mirrorArray(array);