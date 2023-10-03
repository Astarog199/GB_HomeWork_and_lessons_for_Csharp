/*
Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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


void Revers(int[] array)
{
    int[] reversArray = new int[array.Length];
    for (int position = 0; position < array.Length; position++)
    {
        reversArray[position] = array[position] *= (-1);
    }
    Console.Write($"Замена занака в массиве ");
    PrintArray(reversArray);
}


int[] array = FillArray(-9, 9, 12);
PrintArray(array);
Revers(array);