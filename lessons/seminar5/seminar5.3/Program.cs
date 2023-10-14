/*
Задайте массив. Которая определяет есть заданное число в массиве или нет
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
bool isPresent(int[] array, int num)
{
    for (int position = 0; position < array.Length; position++)
    {
        if (array[position] == num)
        {
            return true;
        }
    }
    return false;
}

Console.Write($"Enter numb is search: ");
int num = Convert.ToInt32(Console.ReadLine());


int[] array = FillArray(0, 9, 12);
PrintArray(array);
Console.Write(isPresent(array, num));