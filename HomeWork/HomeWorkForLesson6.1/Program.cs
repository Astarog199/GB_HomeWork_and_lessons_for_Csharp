/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Создание массива и заполнение его

int[] FillArray(int size)

{
    int[] array = new int[size];

    for (int index = 0; index < size; index++)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;

    Console.Write($"Массив из {size} элементов -> [");

    for (int position = 0; position < size; position++)
    {
        Console.Write($"{array[position]}");
        if (array.Length > position + 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine("]");
}

void Calc(int[] array)
{
    int res = 0;
    for (int position = 0; position < array.Length; position++)
    {
        if (array[position] > 0)
        {
            res++;
        }
    }
    Console.WriteLine($"quantity is more than 0-> {res}");
}

Console.Write("Введите число элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size);
PrintArray(array);
Calc(array);